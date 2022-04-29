using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Data
    {
        public static List<Disciplina> Disciplinas { get; set; }
        public static List<Aluno> Alunos { get; set; }
        public static List<AlunoDisciplina> AlunoDisciplina { get; set; }

        public static void SetAlunoDisciplina()
        {
            foreach (AlunoDisciplina alunoDisciplina in Data.AlunoDisciplina)
            {
                foreach (Aluno aluno in Data.Alunos)
                {
                    if (alunoDisciplina.IdAluno == aluno.IdAluno)
                    {
                        foreach (Disciplina disciplina in Data.Disciplinas)
                        {
                            if (alunoDisciplina.IdDisciplina == disciplina.IdDisciplina)
                            {
                                aluno.AddDisciplina(disciplina);
                            }
                        }
                    }
                }
            }
        }

        public static void UpdateCurrentAluno(Aluno aluno)
        {
            if(Alunos.Any(a => a.IdAluno == aluno.IdAluno))
            {
            }
        }

        public static void PrintAlunoDisciplina()
        {
            foreach(Aluno aluno in Alunos)
            {
                foreach(Disciplina disciplina in aluno.Disciplinas)
                {
                    System.Diagnostics.Debug.WriteLine(disciplina.FullData);
                }
            }
        }
    }
}
