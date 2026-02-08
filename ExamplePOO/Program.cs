using System.Security.Cryptography;
using ExamplePOO.Interfaces;
using ExamplePOO.Models;


using System;

using System;

namespace ChatBotNET
{
    // Classe responsável por armazenar e responder mensagens de saudação
    class Mensagem
    {
        private string saudacao;

        public Mensagem(string saudacao)
        {
            this.saudacao = saudacao;
        }

        // TODO: Modifique este método para personalizar a resposta do bot de acordo com critérios fornecidos pelo enunciado
        // Dica: avalie o conteúdo da saudação para determinar a resposta adequada
        
        public string responder()
        {
            // Atualmente, apenas retorna um padrão fixo. 
            // O aluno deve alterar para adaptar às regras do desafio.
            return $"BOT: Obrigado pela mensagem: {saudacao}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lê a frase enviada pelo cliente via stdin
            string entrada = Console.ReadLine();
            
            // Instancia a classe Mensagem para processar a entrada
            Mensagem mensagem = new Mensagem(entrada);

            // Imprime a resposta do bot no formato especificado
            Console.WriteLine(mensagem.responder());
        }
    }
}





// Icalculadora calc = new Calculadora();

// Console.WriteLine(calc.Somar(10, 20));
// Console.WriteLine(calc.Dividir(10, 20));






// Computador c = new Computador();
// Console.WriteLine(c.ToString());





// Pessoa pessoa2 = new Pessoa("Cássio");
// pessoa2.Apresentar();

// Aluno a2 = new Aluno();
// a2.Nome = "Victor";
// a2.Apresentar();

// Professor p2 = new Professor("Cássio");
// p2.Apresentar();






// // Exemplo de polimorfismo em tempo de execução


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Cássio";
// pessoa1.Idade = "30";

// pessoa1.Apresentar();


// Aluno a1 = new Aluno();

// a1.Nome = "Victor";
// a1.Idade = "15";
// a1.Nota = 270;
// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Cássio";
// p1.Idade = "30";
// p1.Salario = 1000;
// p1.Apresentar();







// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();

// c1.Sacar(500);

// c1.ExibirSaldo();


// Corrente c = new Corrente();

// c.Creditar(100);

// c.ExibirSaldo();