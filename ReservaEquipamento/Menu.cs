using ReservaEquipamento.Telas.ManterEquipamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ReservaEquipamento.Telas.ManterProfessor;

namespace ReservaEquipamento
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnManterEquipamento_Click(object sender, EventArgs e)
        {
            MenuManterEquipamento menuEquipamento = new MenuManterEquipamento();
            menuEquipamento.Tag = this;
            menuEquipamento.Show(this);
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuManterProfessor menuProfessor = new MenuManterProfessor();
            menuProfessor.Tag = this;
            menuProfessor.Show(this);
            this.Hide();
        }
    }
}
