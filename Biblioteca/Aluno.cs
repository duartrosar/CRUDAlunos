using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        
        
        public string Name { get; set; }

        
        public string Surname { get; set; }


        public List<Disciplina> Disciplinas { get; set; }

        //private Aluno() { }

        public Aluno()
        {
            Disciplinas = new List<Disciplina>();
        }

        /// <summary>
        /// Adiciona uma disciplina ás disciplinas do aluno, caso o aluno não tenha essa disciplina em questão.
        /// </summary>
        /// <param name="disciplina"></param>
        /// <returns>true se o aluno não tiver a disciplina adicionada, senão false</returns>
        public bool AddDisciplina(Disciplina disciplina)
        {
            int idDisciplina = disciplina.IdDisciplina;

            if (!Disciplinas.Any(i => i.IdDisciplina == idDisciplina))
            {
                Disciplinas.Add(disciplina);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove uma disciplina das disciplinas do aluno, caso o aluno não tenha essa disciplina em questão.
        /// </summary>
        /// <param name="disciplina"></param>
        /// <returns>true se o aluno não tiver a disciplina adicionada, senão false</returns>
        public bool RemoveDisciplina(Disciplina disciplina)
        {
            int idDisciplina = disciplina.IdDisciplina;

            if (Disciplinas.Any(i => i.IdDisciplina == idDisciplina))
            {
                Disciplinas.Remove(disciplina);
                return true;
            }
            return false;
        }

        public string FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public override string ToString()
        {
            return $"{IdAluno} - {Name} {Surname}";
        }
    }
}
