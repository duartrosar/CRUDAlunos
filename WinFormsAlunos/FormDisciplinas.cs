using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FormDisciplinas : Form
    {
        int contaDisciplina = 1;
        public FormDisciplinas()
        {
            //_disciplinas = disciplinas;
            InitializeComponent();
            txtIdDisciplina.Text = contaDisciplina.ToString();
            InitList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina;
            if (ValidateForm())
            {
                novaDisciplina = new Disciplina()
                {
                    IdDisciplina = contaDisciplina,
                    Name = txtNome.Text,
                    Description = txtDescription.Text
                };

                Data.Disciplinas.Add(novaDisciplina);

                SQLiteDataAccess.InsertDisciplina(novaDisciplina);

                contaDisciplina++;

                InitList();
            }
        }

        public void InitList()
        {
            listBoxDisciplinas.DataSource = null;
            listBoxDisciplinas.DataSource = Data.Disciplinas;
            listBoxDisciplinas.DisplayMember = "FullData";
        }

        private void btnApagarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaToDelete = (Disciplina)listBoxDisciplinas.SelectedItem;

            Disciplina deleted = null;

            if (disciplinaToDelete != null)
            {
                foreach(Disciplina disciplina in Data.Disciplinas)
                {
                    if (disciplina.IdDisciplina == disciplinaToDelete.IdDisciplina)
                    {
                        deleted = disciplina;
                    }
                }

                if (deleted != null)
                {
                    DialogResult result;

                    result = MessageBox.Show($"Tem a certeza que pretende apagar a diciplina {deleted.Name}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        Data.Disciplinas.Remove(deleted);

                        SQLiteDataAccess.DeleteDisciplina(deleted);
                        Data.Alunos = SQLiteDataAccess.LoadAlunos();
                        Data.SetAlunoDisciplina();
                        InitList();
                    }
                }
            }
        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaToEdit = (Disciplina)listBoxDisciplinas.SelectedItem;
            Disciplina editada = null;

            if (disciplinaToEdit != null)
            {
                foreach (Disciplina aluno in Data.Disciplinas)
                {
                    if (disciplinaToEdit.IdDisciplina == aluno.IdDisciplina)
                    {
                        editada = aluno;
                    }
                }

                // Abrir a nova forma para editar
                EditarDisciplinaForm editarDisciplinaForm = new EditarDisciplinaForm(this, editada);

                editarDisciplinaForm.Show();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome da disciplina",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Insira a descrição da disciplina",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }
    }
}
