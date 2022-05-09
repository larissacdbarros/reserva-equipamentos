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
    public partial class CreateEquipamento : Form
    {
        public string IdSelecionado { get; set; }
        public CreateEquipamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
                       
            string nome = txtNomeEquipamento.Text;

            int quantidade = int.Parse(txtQuantidadeEquipamento.Text);
            EquipamentosRepository equipamentosRepository = new EquipamentosRepository();
            //ediçao ocorre no if
            if (IdSelecionado != null && IdSelecionado != "")
            {
                Equipamento equipamento = new Equipamento(int.Parse(IdSelecionado), nome, quantidade);
                equipamentosRepository.UpdateEquipamento(equipamento);
                var ReadAllEquipamentos = (ReadAllEquipamentos)Tag;


                List<Equipamento> list = equipamentosRepository.ReadAllEquipamento();
                
                ReadAllEquipamentos.listBoxListaEquipamentos.Items.Clear();
                
                foreach (Equipamento eqp in list)
                {
                    ReadAllEquipamentos.listBoxListaEquipamentos.Items.Add($"{eqp.Id} - {eqp.Nome}");

                }

                ReadAllEquipamentos.Show();
                this.Close();
            }
            else
            {
                equipamentosRepository.CreateEquipamento(nome, quantidade);
                var MenuManterEquipamento = (MenuManterEquipamento)Tag;
                MenuManterEquipamento.Show();
                this.Close();
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IdSelecionado != null && IdSelecionado != "")
            {
                var ReadAllEquipamentos = (ReadAllEquipamentos)Tag;
                ReadAllEquipamentos.Show();
                this.Close();
            }
            else
            {
                var MenuManterEquipamento = (MenuManterEquipamento)Tag;
                MenuManterEquipamento.Show();
                this.Close();
            }
          
        }

        private void CreateEquipamento_Load(object sender, EventArgs e)
        {
            

        }

    }
}
