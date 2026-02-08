using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Aluno : Pessoa
    {
        // Esse construtor da a possibilidade de criar um objeto Aluno sem passar o nome como parâmetro
        public Aluno()
        {
            
        }
        // Esse construtor obriga a criar um objeto Aluno passando o parâmetro, quando não é feito o construtor acima.
        public Aluno(string nome) : base(nome)
        {
            
        }

        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}