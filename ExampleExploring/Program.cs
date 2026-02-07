using ExampleExploring.Models;
using System.Globalization; // Travando a configuração do programa no país desejado

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // Travando a configuração do programa no país desejado


// Pessoa p1 = new Pessoa(nome: "Cássio", sobrenome: "Pereira");

// Pessoa p2 = new Pessoa(nome: "Dilnara", sobrenome: "Pereira");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.ListarAlunos();

// cursoDeIngles.AdicionarALuno(p1);
// cursoDeIngles.AdicionarALuno(p2);

// cursoDeIngles.ListarAlunos();

// cursoDeIngles.ObterQuantidadeDeAlunosMatriculados();

// cursoDeIngles.RemoverAluno(p1);

// cursoDeIngles.ListarAlunos();




// // Lembrando como funciona o concatenação de string
// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// decimal valorMotenatio = 1582.40M;

// // O :C irá configurar a moeda no valor em que a maquina está configurada
// // Se está configurada no Brasil, será real e assim por diante
// // Modo flexível.
// Console.WriteLine($"{valorMotenatio:C}");

// Console.WriteLine(valorMotenatio.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

// Console.WriteLine(valorMotenatio.ToString("C4"));

// Console.WriteLine(valorMotenatio.ToString("C3"));


// double porcentagem = .4321;

// Console.WriteLine(porcentagem.ToString("P"));





// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


// DateTime data = DateTime.Now;

// Console.WriteLine(data);

// Console.WriteLine(data.ToString("dd/MM/yyyy"));

// Console.WriteLine(data.ToString("dd-MM-yyyy"));

// Console.WriteLine(data.ToString("HH:mm:ss"));

// Console.WriteLine(data.ToShortDateString());

// Console.WriteLine(data.ToShortTimeString());

// DateTime date = DateTime.Parse("16/03/2023 18:00");

// Console.WriteLine(date);

// string dataString = "2002/13/22 20:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy/MM/dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);

// if (sucesso)
// {
//     Console.WriteLine(date);
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }



// try
// {
//     string[] linhas = File.ReadAllLines("arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }





// new ExceptionExample().Metodo1();



// // Fila
// // FIFO (FIRST INTO, FIRST OUT)
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(3);
// fila.Enqueue(4);
// fila.Enqueue(5);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"\nRemovendo o elemento: {fila.Dequeue()}\n");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }





// //Stack (Pilha) LIFO (LAST INTO, FIRST OUT)
// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(2);
// pilha.Push(3);
// pilha.Push(4);
// pilha.Push(5);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"\nRemovendo o elemento: {pilha.Pop()}\n");

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }






// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine("\nListando o dicionário de estados: ");
// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key} - {item.Value}");
// }

// Console.WriteLine($"\nRemovendo o estado: {estados["SP"]}");
// estados.Remove("SP");


// Console.WriteLine("\nListando o dicionário de estados: ");
// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key} - {item.Value}");
// }

// Console.WriteLine($"\nAlterando o valor do estado: {estados["RJ"]}");
// estados["RJ"] = "Rio de Janeiro tem muitas praias.";

// Console.WriteLine("\nListando o dicionário de estados: ");
// foreach (var item in estados)
// {
//     Console.WriteLine($"{item.Key} - {item.Value}");
// }


// string chave = "BA";
// Console.WriteLine($"\nVerificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existente. É seguro adicionar a chave: {chave}");
// }

// Console.WriteLine($"\nValor do estado: {estados["MG"]}");






// // DESAFIO 1
// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Lê o número de comandos a serem processados
//         int n = int.Parse(Console.ReadLine());

//         // Inicializa a estrutura para armazenar sugestões únicas
//         HashSet<string> sugestoes = new HashSet<string>(StringComparer.Ordinal);

//         for (int i = 0; i < n; i++)
//         {
//             string linha = Console.ReadLine();

//             // Divide o comando em ação (ADD/REMOVE) e sugestão
//             int spaceIdx = linha.IndexOf(' ');
//             string acao = linha.Substring(0, spaceIdx);
//             string sugestao = linha.Substring(spaceIdx + 1);

//             // TODO: Implemente o tratamento para as ações de adicionar e remover sugestões
//             // Dica: utilize os métodos disponíveis na estrutura HashSet para gerenciar as sugestões
//             if (acao == "ADD")
//             {
//                 sugestoes.Add(sugestao);
//             }
//             else if (acao == "REMOVE")
//             {
//                 sugestoes.Remove(sugestao);
//             }
//         }

//         // Ao final, exibe as sugestões em ordem alfabética separadas por espaço,
//         // ou "VAZIO" se não houver elementos restantes
//         if (sugestoes.Count == 0)
//         {
//             Console.WriteLine("VAZIO");
//         }
//         else
//         {
//             List<string> ordenadas = sugestoes.ToList();
//             ordenadas.Sort(StringComparer.Ordinal);
//             Console.WriteLine(string.Join(" ", ordenadas));
//         }
//     }
// }





// // DESAFIO 2
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Lê uma linha contendo as tarefas separadas por espaço
//         string input = Console.ReadLine();

//         // Converte a entrada em uma lista de tarefas
//         List<string> tarefas = new List<string>(input.Split(' '));

//         // TODO: Separe as tarefas realizadas ("feito") das tarefas pendentes,
//         //       mantendo a ordem relativa de ambas nas listas.
//         List<string> feito = new List<string>();
//         List<string> outras = new List<string>();
        
//         foreach (string tarefa in tarefas)
//         {
//           if (tarefa == "feito")
//           {
//             feito.Add(tarefa);
//           }
//           else
//           {
//             outras.Add(tarefa);
//           }
//         }

//         // Dica: Percorra todas as tarefas e utilize duas listas diferentes.

//         // Após separar, coloque primeiro as pendentes e depois todas as "feito"
//         // List<string> resultado = ... // Monte a lista final aqui
//         List<string> resultado = new List<string>();
        
//         foreach (string item in outras)
//         {
//           resultado.Add(item);
//         }
        
//         foreach (string item in feito)
//         {
//           resultado.Add(item);
//         }

//         // Imprime as tarefas reordenadas
//         // Console.WriteLine(string.Join(" ", resultado));
        
//         Console.WriteLine(string.Join(" ", resultado));
//     }
// }