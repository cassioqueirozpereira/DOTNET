using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleExploring.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string _nome;
        private int _idade;
        public string Nome 
        {
            // get
            // {
            //     return _nome.ToUpper();
            // }

            // Maneira simplificada de fazer a mesma coisa que acima.
            get => _nome;
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser nulo.");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("A idade não pode ser negativa.");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"{NomeCompleto} tem {Idade} anos.");
        }
    }
}