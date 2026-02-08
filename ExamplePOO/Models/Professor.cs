using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Models
{
    public class Professor : Pessoa
    {
        // Perceba que nessa classe, não usei o construtor que da a possibilidade de criar um objeto sem passar o nome, logo aqui será obrigatório passar o nome no parâmetro.
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é R${Salario}.");
        }
    }
}