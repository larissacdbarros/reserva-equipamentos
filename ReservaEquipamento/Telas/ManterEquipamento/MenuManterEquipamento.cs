using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaEquipamento.Telas.ManterEquipamento
{
    public partial class MenuManterEquipamento : Form
    {
      

        public MenuManterEquipamento()
        {
            InitializeComponent();
        }

        private void MenuManterEquipamento_Load(object sender, EventArgs e)
        {

        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            CreateEquipamento create = new CreateEquipamento();
            create.Tag = this;
            create.Show();
            this.Hide();
        }

        private void btnMinhasReservas_Click(object sender, EventArgs e)
        {
            ReadAllEquipamentos read = new ReadAllEquipamentos();
            read.Tag = this;
            read.Show();
            this.Hide();
        }
    }
}
