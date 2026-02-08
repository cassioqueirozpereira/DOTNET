using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Pessoa
    {
        // Esse construtor da a possibilidade de criar um objeto Pessoa sem passar o nome como parâmetro
        public Pessoa()
        {
            
        }
        // Esse construtor obriga a criar um objeto Pessoa passando o parâmetro, quando não é feito o construtor acima.
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public string Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}