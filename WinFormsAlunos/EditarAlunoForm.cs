using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAlunos
{
    public partial class EditarAlunoForm : Form
    {
        Aluno _editado;

        FormAlunos _form;

        public EditarAlunoForm(FormAlunos form, Aluno editado)
        {
            InitializeComponent();

            _editado = editado;
            _form = form;

            txtIdAluno.Text = editado.IdAluno.ToString();
            txtNome.Text = editado.Name;
            txtApelido.Text = editado.Surname;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                _editado.Name = txtNome.Text;
                _editado.Surname = txtApelido.Text;
                _form.InitList();
                this.Close();
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do aluno", 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtApelido.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
