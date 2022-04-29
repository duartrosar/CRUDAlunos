using Biblioteca;

namespace WinFormsAlunos
{
    public partial class FormAlunos : Form
    {
        //List<Aluno> _alunos;

        List<Disciplina> Disciplinas;

        Aluno alunoTemp = null;

        int contaAlunos = 1;
        public FormAlunos()
        {
            InitializeComponent();

            AttributeDisciplinas();

            txtIdAluno.Text = contaAlunos.ToString();
            InitList();
        }

        

        private void AttributeDisciplinas()
        {
            
        }

        private void FormAlunos_Load(object sender, EventArgs e)
        {
            //PopulateDisciplinas();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno;

            if (ValidateForm())
            {
                novoAluno = new Aluno()
                {
                    IdAluno = contaAlunos,
                    Name = txtNome.Text,
                    Surname = txtApelido.Text
                };

                Data.Alunos.Add(novoAluno);

                contaAlunos++;

                SQLiteDataAccess.InsertAluno(novoAluno);

                InitList();
            }
            else
            {
                MessageBox.Show("Preenche corretamento os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNome.Clear();
            txtApelido.Clear();
            txtIdAluno.Text = contaAlunos.ToString();
            txtNome.Focus();    
        }

        #region Init List podem ser apenas um método
        public void InitList()
        {
            listBoxAlunos.DataSource = null;
            listBoxAlunos.DataSource = Data.Alunos;
            listBoxAlunos.DisplayMember = "FullName";
        }

        public void InitListAlunos()
        {
            listBoxDisciplinasAluno.DataSource = null;

            if (alunoTemp != null)
            {
                listBoxDisciplinasAluno.DataSource = alunoTemp.Disciplinas;
                listBoxDisciplinasAluno.DisplayMember = "FullData";
            }
        }
        #endregion

        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtApelido.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtApelido.Text = string.Empty;
        }

        private void btnApagarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoToDelete = (Aluno)listBoxAlunos.SelectedItem;

            Aluno deleted = null;

            if (alunoToDelete != null)
            {
                foreach (Aluno aluno in Data.Alunos)
                {
                    if (alunoToDelete.IdAluno == aluno.IdAluno)
                    {
                        deleted = aluno;
                    }
                }

                if(deleted != null)
                {
                    DialogResult resposta;

                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {deleted.FullName}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if(DialogResult.OK == resposta)
                    {
                        Data.Alunos.Remove(deleted);
                        SQLiteDataAccess.DeleteAluno(deleted);
                        InitList();

                        if (listBoxAlunos.Items.Count > 0)
                        {
                            alunoTemp = (Aluno)listBoxAlunos.Items[0];
                        }

                        InitListAlunos();
                    }
                }
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoToEdit = (Aluno)listBoxAlunos.SelectedItem;
            Aluno editado = null;

            if(alunoToEdit != null) 
            {
                foreach(Aluno aluno in Data.Alunos)
                {
                    if (alunoToEdit.IdAluno == aluno.IdAluno)
                    {
                        editado = aluno;
                    }
                }

                // Abrir a nova forma para editar
                EditarAlunoForm editarAlunoForm = new EditarAlunoForm(this, editado);

                editarAlunoForm.Show();
            }

        }

        private void btnAdicionarDisciplina_Click(object sender, EventArgs e)
        {
            alunoTemp = (Aluno)listBoxAlunos.SelectedItem;

            Aluno editado = null;

            if (alunoTemp != null)
            {
                foreach(Aluno aluno in Data.Alunos)
                {
                    editado = aluno;
                }

                AdicionarDisciplina adicionarDisciplina = new AdicionarDisciplina(this, alunoTemp);

                adicionarDisciplina.ShowDialog();
            }
        }

        //private void PopulateDisciplinas()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Disciplinas.Add(new Disciplina()
        //        {
        //            IdDisciplina = i,
        //            Name = $"Disciplina {i + 1}",
        //            Description = $"{Name} Descrição"
        //        });
        //    }
        //}

        private void listBoxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            alunoTemp = (Aluno)listBoxAlunos.SelectedItem;

            if (alunoTemp != null)
            {
                InitListAlunos();
            }
        }
    }
}