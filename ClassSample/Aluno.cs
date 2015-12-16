using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    public class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("Aluno Consctrutor");
        }

        //Fields
        private string nome;
        private int idade;

        //Proprieties
        public string Nome
        {
            get {
                return nome;
            }
            set {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if(value >= 10)
                    idade = value;
            }
        }

        ~Aluno()
        {
            Console.WriteLine("Aluno Destructor");
        }
    }
}
