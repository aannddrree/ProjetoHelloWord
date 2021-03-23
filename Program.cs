using System;
using ProjetoHelloWord.Model;

namespace ProjetoHelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pessoa pessoa = new Pessoa(){
              Id = 1,
              Nome = "André"
            };

            Console.WriteLine("Hello World! \n" + pessoa);
        }
    }
}
