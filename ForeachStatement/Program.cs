using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachStatement
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }

        static void Main(string[] args)
        {
            //Livro l1 = new Livro();
            Livro l1;
            l1.codigo = 1;
            l1.autor = "Machado de Assis";
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2;
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 1965;
        }
    }
}
