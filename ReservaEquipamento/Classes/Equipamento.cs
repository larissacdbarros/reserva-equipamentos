﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservaEquipamento.Classes
{
    internal class Equipamento
    {
        public  int Id{ get; set; }
        public string Nome { get; set; }
        public int QtdEquipamento { get; set; }
        public bool IsReservado { get; set; }
       
    }
}
