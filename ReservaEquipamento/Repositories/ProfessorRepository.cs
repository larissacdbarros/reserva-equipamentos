using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReservaEquipamento.Classes.Repositories
{
    internal class ProfessorRepository
    {
        public static string NomeArquivo { get; set; }

        Config config = new Config("\\professor-repository.txt");

        public void CreateProfessor(string nome, string cpf, string disciplica, bool coordenador, string login, string senha)
        {
            int maxId = 0;
            List<Professor> listProfessor = ReadAllProfessor();
            
            foreach (Professor prof in listProfessor)
            {
                if (prof.Id > maxId)
                {
                    maxId = prof.Id;
                }
            }

            Professor professor = new Professor(maxId + 1, nome, cpf, disciplica, coordenador, login, senha);


            StreamWriter e = File.AppendText(config.Diretorio + config.Arquivo);
            e.WriteLine($"{professor.Id}-{professor.Nome}-{professor.Cpf}-{professor.Disciplina}-{professor.IsCoordenador}-" +
                $"{professor.Login}-{professor.Senha}");
            e.Close();

        }

        public List<Professor> ReadAllProfessor()
        {
            List<Professor> listaProfessor = new List<Professor>();

            string[] lines = File.ReadAllLines(config.Diretorio + config.Arquivo);

            foreach (string line in lines)
            {
                string[] values = line.Split('-');
                listaProfessor.Add(new Professor(int.Parse(values[0]), values[1], values[2], values[3], System.Convert.ToBoolean(values[4]), values[5], values[6]));
            }

            return listaProfessor;

        }

        public void UpdateProfessor(Professor professorUpdate)
        {
            List<Professor> listProfessor = ReadAllProfessor();

            List<string> lines = new List<string>();

            foreach (Professor professor in listProfessor)
            {
                if (professor.Id == professorUpdate.Id)
                {
                    lines.Add($"{professorUpdate.Id}-{professorUpdate.Nome}-{professorUpdate.Cpf}-{professorUpdate.Disciplina}-" +
                        $"{professorUpdate.IsCoordenador}-{professorUpdate.Login}-{professorUpdate.Senha}");
                }
                else
                {
                    lines.Add($"{professor.Id}-{professor.Nome}-{professor.Cpf}-{professor.Disciplina}-{professor.IsCoordenador}-" +
                $"{professor.Login}-{professor.Senha}");
                }

            }

            File.Delete(config.Diretorio + config.Arquivo);
            File.WriteAllLines(config.Diretorio + config.Arquivo, lines.ToArray());
        }

        public void DeleteProfessor(int id)
        {
            List<Professor> listProfessor = ReadAllProfessor();
            listProfessor.RemoveAt(id);

            List<string> lines = new List<string>();
            foreach (Professor professor in listProfessor)
            {
                lines.Add($"{professor.Id}-{professor.Nome}-{professor.Cpf}-{professor.Disciplina}-{professor.IsCoordenador}-" +
                $"{professor.Login}-{professor.Senha}");
            }

            File.Delete(config.Diretorio + config.Arquivo);
            File.WriteAllLines(config.Diretorio + config.Arquivo, lines.ToArray());
        }



    }
}
