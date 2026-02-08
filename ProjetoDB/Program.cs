using ProjetoDB;
using ProjetoDB.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;











// Criando a Tabela Clientes
using var db = new AppDbContext();

// 1. Caminho para o arquivo SQL
string caminhoScript = "scripts/TabelaCliente.sql";

if (File.Exists(caminhoScript))
{
    Console.WriteLine("Lendo o arquivo de script...");
    string comandoSql = File.ReadAllText(caminhoScript);
    var comandos = comandoSql.Split(new[] { "\r\nGO", "\nGO", "\rGO", "GO\r", "GO\n" }, StringSplitOptions.RemoveEmptyEntries);

    try 
    {
        // 2. Executa o SQL puro diretamente no banco
        // Isso vai rodar o DROP, o CREATE e todos os INSERTS do arquivo
        foreach (var comando in comandos)
        {
            string cmdLimpo = comando.Trim();
            if (!string.IsNullOrWhiteSpace(cmdLimpo))
            {
                db.Database.ExecuteSqlRaw(cmdLimpo);
            }
        }
        Console.WriteLine("Script executado e tabela preenchida com sucesso (tratando os GO)!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao executar o script: {ex.Message}");
    }
}
else
{
    Console.WriteLine("Arquivo script.sql não encontrado na raiz do projeto.");
}











// // Select
// using var db = new AppDbContext();

// Console.WriteLine("--- EXECUTANDO: SELECT * FROM Clientes ---");

// // O comando .ToList() é o que dispara o SELECT * para o banco
// var listaDeClientes = db.Clientes.ToList();

// if (listaDeClientes.Any())
// {
//     foreach (var c in listaDeClientes)
//     {
//         // Aqui você acessa as propriedades que criamos na Model Cliente
//         Console.WriteLine($"ID: {c.Id} | Nome: {c.Nome} {c.Sobrenome} | Email: {c.Email}");
//     }
// }
// else
// {
//     Console.WriteLine("A tabela está vazia!");
// }












// // Usando comando de Select no C#
// using var db = new AppDbContext();

// Console.WriteLine("=== BUSCA DE PRODUTOS NO SQL SERVER ===");

// // 1. Filtrar produtos por cor (ex: 'Preto')
// Console.WriteLine("\n> Produtos da cor 'Preto':");
// var pretos = db.Produtos.Where(p => p.Cor == "Preto").ToList();
// ExibirLista(pretos);

// // 2. Filtrar produtos caros (Preço > 50)
// Console.WriteLine("\n> Produtos com preço acima de R$ 50,00:");
// var caros = db.Produtos.Where(p => p.Preco > 50).ToList();
// ExibirLista(caros);

// // 3. Buscar um produto específico pelo nome (contendo 'Jersey')
// Console.WriteLine("\n> Busca por nome contendo 'Jersey':");
// var camisetas = db.Produtos
//     .Where(p => p.Nome.Contains("Jersey"))
//     .OrderByDescending(p => p.Preco) // Ordenar do mais caro para o mais barato
//     .ToList();
// ExibirLista(camisetas);

// // Método auxiliar para não repetir código de impressão
// void ExibirLista(List<Produto> lista)
// {
//     if (!lista.Any()) {
//         Console.WriteLine("Nenhum resultado encontrado.");
//         return;
//     }
//     foreach (var p in lista)
//     {
//         Console.WriteLine($"- {p.Nome.PadRight(30)} | Preço: {p.Preco:C2} | Cor: {p.Cor}");
//     }
// }











// // Criando a Tabela Clientes
// using var db = new AppDbContext();

// // 1. Caminho para o arquivo SQL
// string caminhoScript = "scripts/TabelaCliente.sql";

// if (File.Exists(caminhoScript))
// {
//     Console.WriteLine("Lendo o arquivo de script...");
//     string comandoSql = File.ReadAllText(caminhoScript);
//     var comandos = comandoSql.Split(new[] { "\r\nGO", "\nGO", "\rGO", "GO\r", "GO\n" }, StringSplitOptions.RemoveEmptyEntries);

//     try 
//     {
//         // 2. Executa o SQL puro diretamente no banco
//         // Isso vai rodar o DROP, o CREATE e todos os INSERTS do arquivo
//         foreach (var comando in comandos)
//         {
//             string cmdLimpo = comando.Trim();
//             if (!string.IsNullOrWhiteSpace(cmdLimpo))
//             {
//                 db.Database.ExecuteSqlRaw(cmdLimpo);
//             }
//         }
//         Console.WriteLine("Script executado e tabela preenchida com sucesso (tratando os GO)!");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Erro ao executar o script: {ex.Message}");
//     }
// }
// else
// {
//     Console.WriteLine("Arquivo script.sql não encontrado na raiz do projeto.");
// }





















// // Criando a Tabela Produto, no banco de dados
// using var db = new AppDbContext();

// // 1. Caminho para o arquivo SQL
// string caminhoScript = "scripts/TabelaProduto.sql";

// if (File.Exists(caminhoScript))
// {
//     Console.WriteLine("Lendo o arquivo de script...");
//     string comandoSql = File.ReadAllText(caminhoScript);

//     try 
//     {
//         // 2. Executa o SQL puro diretamente no banco
//         // Isso vai rodar o DROP, o CREATE e todos os INSERTS do arquivo
//         db.Database.ExecuteSqlRaw(comandoSql);
//         Console.WriteLine("Script executado e tabela preenchida com sucesso!");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Erro ao executar o script: {ex.Message}");
//     }
// }
// else
// {
//     Console.WriteLine("Arquivo script.sql não encontrado na raiz do projeto.");
// }

// // 3. Teste de leitura para confirmar os dados
// var lista = db.Produtos.ToList();
// foreach (var p in lista)
// {
//     Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Preço: R$ {p.Preco}");
// }