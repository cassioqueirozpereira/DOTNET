using System.ComponentModel;
using System.Diagnostics;
using ExemploFundamentos.Common.Models;




// Calculadora calculadora = new Calculadora();

// calculadora.Somar(10, 20);
// calculadora.Subtrair(10, 20);
// calculadora.Multiplicar(10, 20);
// calculadora.Dividir(10, 20);
// calculadora.Potencia(10, 20);
// calculadora.RaizQuadrada(30);
// calculadora.Seno(30);
// calculadora.Cosseno(30);
// calculadora.Tangente(30);




// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 20;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada com sucesso!");
// }
// else
// {
//     Console.WriteLine("\nNão foi possível realizar a venda.");
//     Console.WriteLine($"Há apenas {quantidadeEmEstoque} unidades em estoque!\n\n\n");
// }




// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Atualizar Cliente");
//     Console.WriteLine("4 - Excluir Cliente");
//     Console.WriteLine("5 - Sair");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Atualização de Cliente");
//             break;
//         case "4":
//             Console.WriteLine("Exclusão de Cliente");
//             break;
//         case "5":
//             Console.WriteLine("Encerrando o programa...");
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida!");
//             break;
//     }
// }

// Console.WriteLine("Fim do programa!");




// int[] arrayInteiros = new int [4];

// arrayInteiros[0] = 1;
// arrayInteiros[1] = 2;
// arrayInteiros[2] = 3;
// arrayInteiros[3] = 4;


// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// // Como funciona o método Array.Resize
// int []arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// // Primeiro argumento da função, qual é o array a ser copiado, segundo argumento, para qual variável vc quer copiar, terceiro argumento, quantos elementos pretende copiar.
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// Console.WriteLine("Percorrendo o array com o FOR");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     Console.WriteLine($"Posição Nº{i} = {arrayInteiros[i]}");
// }


// Console.WriteLine("Percorrendo o array com o FOR EACH");

// int contadorForeach = 0;
// foreach (int numero in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº{contadorForeach} = {numero}");
//     contadorForeach++;
// }




// A principal diferença do array e lista é que na lista não precisamos passar o tamanho dela. A lista de redimenciona automaticamente a medida que adicionamos elementos nela. A lista é como se fosse uma extensão do array ou um array melhorado.

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");
listaString.Add("ES");


Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("BA");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");




Console.WriteLine("Percorrendo o array com o FOR");
for(int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição Nº{i} = {listaString[i]}");
}


Console.WriteLine("Percorrendo o array com o FOREACH");
int contador = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição Nº{contador} = {item}");
    contador++;
}