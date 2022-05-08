using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEquipamento.Classes
{
    internal class ReservaEquipamento
    {
        public int Id { get; set; }
        public Professor Professor { get; set; }
        public List<Equipamento> Equipamentos { get; set; }
        public DateTime DataHora { get; set; }
    }
}
