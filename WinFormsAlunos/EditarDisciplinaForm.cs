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
    public partial class EditarDisciplinaForm : Form
    {
        Disciplina _editada;

        FormDisciplinas _form;
        public EditarDisciplinaForm(FormDisciplinas form, Disciplina editada)
        {
            InitializeComponent();
            _editada = editada;
            _form = form;

            txtIdDisciplina.Text = editada.IdDisciplina.ToString();
            txtNome.Text = editada.Name;
            txtDescription.Text = editada.Description;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                _editada.Name = txtNome.Text;
                _editada.Description = txtDescription.Text;
                _form.InitList();
                this.Close();
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
    }
}
