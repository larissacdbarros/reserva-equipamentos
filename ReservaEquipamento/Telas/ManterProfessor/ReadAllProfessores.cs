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
    public partial class ReadAllProfessores : Form
    {
        public ReadAllProfessores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ReadAllProfessores_Load(object sender, EventArgs e)
        {
            ProfessorRepository professorRepository = new ProfessorRepository();
            List<Professor> list = professorRepository.ReadAllProfessor();

            foreach (Professor professor in list)
            {
                listBoxListaProfessores.Items.Add($"{professor.Id} - {professor.Nome} - {professor.Cpf}");

            }

        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            string id = listBoxListaProfessores.SelectedItem.ToString().Split('-')[0].Trim();
            CreateProfessor createProfessor = new CreateProfessor();
            createProfessor.IdSelecionado = id;

            createProfessor.Tag = this;
            createProfessor.Show();
            this.Hide();
        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            ProfessorRepository professorRepository = new ProfessorRepository();
            string id = listBoxListaProfessores.SelectedIndex.ToString().Split('-')[0].Trim();
            professorRepository.DeleteProfessor(int.Parse(id));

            listBoxListaProfessores.Items.Clear();

            List<Professor> list = professorRepository.ReadAllProfessor();

            foreach (Professor professor in list)
            {
                listBoxListaProfessores.Items.Add($"{professor.Id} - {professor.Nome} - {professor.Cpf}");

            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            var MenuManterProfessor = (MenuManterProfessor)Tag;
            MenuManterProfessor.Show();
            this.Close();
        }
    }
}
