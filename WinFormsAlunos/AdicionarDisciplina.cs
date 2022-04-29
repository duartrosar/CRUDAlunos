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
    public partial class AdicionarDisciplina : Form
    {
        Aluno _alunoTemp;

        FormAlunos _form;
        public AdicionarDisciplina(FormAlunos form, Aluno alunoTemp)
        {
            InitializeComponent();

            _alunoTemp = alunoTemp;

            _form = form;

            comboDisciplinas.DataSource = Data.Disciplinas;

            comboDisciplinas.DisplayMember = "FullData";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = (Disciplina)comboDisciplinas.SelectedItem;
            Console.WriteLine($"Hello");
            if (disciplina != null)
            {
                if (_alunoTemp.AddDisciplina(disciplina))
                {
                    _form.InitListAlunos();
                    AlunoDisciplina alunoDisciplina = new AlunoDisciplina()
                    {
                        IdAluno = _alunoTemp.IdAluno,
                        IdDisciplina = disciplina.IdDisciplina
                    };
                    SQLiteDataAccess.InsertAlunoDisciplina(alunoDisciplina);
                    Data.AlunoDisciplina = SQLiteDataAccess.LoadAlunoDisciplina();
                    Data.SetAlunoDisciplina();

                    this.Close();
                }   
            }
        }

        private void comboDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
