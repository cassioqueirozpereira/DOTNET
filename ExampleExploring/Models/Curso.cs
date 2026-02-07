using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleExploring.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarALuno(Pessoa aluno)
        {
            Console.WriteLine($"\nAluno adicionado: {aluno.NomeCompleto}");
            Alunos.Add(aluno);
        }

        public void ObterQuantidadeDeAlunosMatriculados()
        {
            Console.WriteLine($"\nQuantidade de alunos matriculados: {Alunos.Count()}");
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Console.WriteLine($"\nAluno removido: {aluno.NomeCompleto}");
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"\nAlunos do curso de {Nome}:");
            if (Alunos.Count() == 0)
            {
                Console.WriteLine("Nenhum aluno matriculado.");
                return;
            }

            for (int count = 0; count < Alunos.Count(); count++)
            {
                // string texto = "Nº " + (count + 1) + ": " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count + 1}: {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}