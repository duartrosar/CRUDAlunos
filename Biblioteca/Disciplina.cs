using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }


        public string Name { get; set; }


        public string Description { get; set; }


        public List<Aluno> Alunos { get; set; }

        //private Disciplina() { }

        public Disciplina()
        {
            Alunos = new List<Aluno>();
        }

        public string FullData
        {
            get
            {
                return $"{Name} - {Description}";
            }
        }
    }
}
