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
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();

            GetData();
        }

        private async void GetData()
        {
            Data.Alunos = SQLiteDataAccess.LoadAlunos();
            Data.Disciplinas = SQLiteDataAccess.LoadDisciplinas();
            Data.AlunoDisciplina = SQLiteDataAccess.LoadAlunoDisciplina();
            Data.SetAlunoDisciplina();

            //Data.Alunos = await SQLiteDataAccess.LoadAlunos();
            ////Data.Alunos = SQLiteDataAccess.LoadAlunosTest();
            //Data.Disciplinas = await SQLiteDataAccess.LoadDisciplinas();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            FormAlunos formAlunos = new FormAlunos();
            formAlunos.ShowDialog();
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            FormDisciplinas formDisciplinas = new FormDisciplinas();
            formDisciplinas.ShowDialog();
        }

    }
}
