using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaEquipamento.Telas.ManterProfessor
{
    public partial class MenuManterProfessor : Form
    {
        public MenuManterProfessor()
        {
            InitializeComponent();
        }

        private void MenuManterProfessor_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            CreateProfessor create = new CreateProfessor();
            create.Tag = this;
            create.Show();
            this.Hide();
        }

        private void btnListarProfessores_Click(object sender, EventArgs e)
        {
            ReadAllProfessores read = new ReadAllProfessores();
            read.Tag = this;
            read.Show();
            this.Hide();
        }
    }
}
