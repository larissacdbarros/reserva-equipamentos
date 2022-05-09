using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReservaEquipamento.Classes
{

    internal class EquipamentosRepository
    {
        
        Config config = new Config("\\equipamento-repository.txt");
        
        public void CreateEquipamento(string nome, int quantidade)
        {
            
            int maxId = 0;
            List<Equipamento> listEquipamento = ReadAllEquipamento();
            foreach (Equipamento eqp in listEquipamento)
            {
                if (eqp.Id > maxId)
                {
                    maxId = eqp.Id;
                }
            }
            Equipamento equipamento = new Equipamento(maxId + 1, nome, quantidade);

            StreamWriter e  = File.AppendText(config.Diretorio + config.Arquivo);
            e.WriteLine($"{equipamento.Id}-{equipamento.Nome}-{equipamento.QtdEquipamento}");
            e.Close();

           
        }

        public List<Equipamento> ReadAllEquipamento ()
        {
            List<Equipamento> listaEquipamento = new List<Equipamento>();
             
            string[] lines = File.ReadAllLines(config.Diretorio + config.Arquivo);

            foreach (string line in lines)
            {
                string[] values = line.Split('-');
                listaEquipamento.Add(new Equipamento(int.Parse(values[0]), values[1], int.Parse(values[2])));
            }

            return listaEquipamento;
            
        }

        public void ReadEquipamento(string nome)
        {
           
        }
        public void UpdateEquipamento(Equipamento equipamentoUpdate)
        {
            List<Equipamento> listEquipamento = ReadAllEquipamento();

            List<string> lines = new List<string>();

            foreach (Equipamento equipamento in listEquipamento)
            {
                if(equipamento.Id == equipamentoUpdate.Id)
                {
                    lines.Add($"{equipamentoUpdate.Id}-{equipamentoUpdate.Nome}-{equipamentoUpdate.QtdEquipamento}");
                }
                else
                {
                    lines.Add($"{equipamento.Id}-{equipamento.Nome}-{equipamento.QtdEquipamento}");
                }
                
            }

            File.Delete(config.Diretorio + config.Arquivo);
            File.WriteAllLines(config.Diretorio + config.Arquivo, lines.ToArray());
        }
        public void DeleteEquipamento(int id)
        {
            List<Equipamento> listEquipamento = ReadAllEquipamento();
            listEquipamento.RemoveAt(id);

            List<string> lines =  new List<string>();
            foreach(Equipamento equipamento in listEquipamento)
            {
                lines.Add($"{equipamento.Id}-{equipamento.Nome}-{equipamento.QtdEquipamento}");
            }

            File.Delete(config.Diretorio + config.Arquivo);
            File.WriteAllLines(config.Diretorio + config.Arquivo, lines.ToArray());   
        }

    }
}
