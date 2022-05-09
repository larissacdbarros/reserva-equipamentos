using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEquipamento.Classes
{
    internal class Equipamento
    {
        public  int Id{ get; set; } 
        //a cada equipamento cadastrado Id++
        public string Nome { get; set; }
        public int QtdEquipamento { get; set; }
        public bool IsAllReservado { get; set; }
       
        public Equipamento(int id, string nome, int qtdEquipamento)
        {
            
            this.Nome = nome;
            this.QtdEquipamento = qtdEquipamento;
            this.Id = id;
            
        }
    }
  
}
