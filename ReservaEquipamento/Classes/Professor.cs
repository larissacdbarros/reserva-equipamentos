using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEquipamento.Classes
{
    internal class Professor
    {
        public int Id {get;set;}
        public string Nome{ get; set; }
        public string Cpf { get; set; }
        public string Disciplina { get; set; }
        public bool IsCoordenador { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Professor(int id, string nome, string cpf, string disciplina, bool coordenador, string login, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Disciplina = disciplina;
            this.IsCoordenador = coordenador;
            this.Login = login;
            this.Senha = senha;
        }
    }

}
