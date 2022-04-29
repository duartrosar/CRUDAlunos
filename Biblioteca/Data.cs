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
    }
}
