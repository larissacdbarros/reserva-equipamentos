using ReservaEquipamento.Classes;
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
    public partial class ReadAllEquipamentos : Form
    {
        public ReadAllEquipamentos()
        {
            InitializeComponent();
        }

        private void ReadAllEquipamentos_Load(object sender, EventArgs e)
        {
            EquipamentosRepository equipamentosRepository = new EquipamentosRepository();
            List<Equipamento> list = equipamentosRepository.ReadAllEquipamento();

            foreach (Equipamento equipamento in list)
            {
                listBoxListaEquipamentos.Items.Add($"{equipamento.Id} - {equipamento.Nome}");

            }

        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            string id = listBoxListaEquipamentos.SelectedItem.ToString().Split('-')[0].Trim();
            CreateEquipamento createEquipamento = new CreateEquipamento();
            createEquipamento.IdSelecionado = id;

            createEquipamento.Tag = this;
            createEquipamento.Show();
            this.Hide();
        }

        private void listBoxListaEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipamentosRepository equipamentosRepository = new EquipamentosRepository();
            string id = listBoxListaEquipamentos.SelectedIndex.ToString().Split('-')[0].Trim();
            equipamentosRepository.DeleteEquipamento(int.Parse(id));

            listBoxListaEquipamentos.Items.Clear();
            
            List<Equipamento> list = equipamentosRepository.ReadAllEquipamento();

            foreach (Equipamento equipamento in list)
            {
                listBoxListaEquipamentos.Items.Add($"{equipamento.Id} - {equipamento.Nome}");

            }

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            var MenuManterEquipamento = (MenuManterEquipamento)Tag;
            MenuManterEquipamento.Show();
            this.Close();
        }
    }
}
