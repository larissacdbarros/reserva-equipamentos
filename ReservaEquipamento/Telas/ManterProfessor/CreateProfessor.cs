using ReservaEquipamento.Classes;
using ReservaEquipamento.Classes.Repositories;
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
    public partial class CreateProfessor : Form
    {
        public string IdSelecionado { get; set; }
        public CreateProfessor()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProfessor.Text;
            string cpf = txtCPFProfessor.Text;
            string disciplina = txtDisciplinaProfessor.Text;
            bool coordenador = rbSim.Checked;
            string login  = txtUsuarioProfessor.Text;
            string senha = txtSenhaProfessor.Text;
            string senhaConfirmar = txtSenhaConfirmaProfessor.Text;
            //fazer validação das senhas aqui

            ProfessorRepository professorRepository = new ProfessorRepository();
            
            //update ocorre no if
            if (IdSelecionado != null && IdSelecionado != "")
            {
                Professor professor = new Professor(int.Parse(IdSelecionado), nome, cpf, disciplina, coordenador, login, senha);
                professorRepository.UpdateProfessor(professor);
                var ReadAllProfessores = (ReadAllProfessores)Tag;

                List<Professor> list = professorRepository.ReadAllProfessor();

                ReadAllProfessores.listBoxListaProfessores.Items.Clear();
                

                foreach (Professor prof in list)
                {
                    ReadAllProfessores.listBoxListaProfessores.Items.Add($"{prof.Id}-{prof.Nome}-{prof.Cpf}-{prof.Disciplina}-" +
                        $"{prof.IsCoordenador}-{prof.Login}-{prof.Senha}");

                }

                ReadAllProfessores.Show();
                this.Close();
            }
            else
            {
                professorRepository.CreateProfessor(nome, cpf, disciplina, coordenador, login, senha);
                var MenuManterProfessor = (MenuManterProfessor)Tag;
                MenuManterProfessor.Show();
                this.Close();
            }
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            // fazer uma validação --> aparece para inserir senha de admin
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (IdSelecionado != null && IdSelecionado != "")
            {
                var ReadAllProfessores = (ReadAllProfessores)Tag;
                ReadAllProfessores.Show();
                this.Close();
            }
            else
            {
                var MenuManterProfessor = (MenuManterProfessor)Tag;
                MenuManterProfessor.Show();
                this.Close();
            }
        }
    }
}
