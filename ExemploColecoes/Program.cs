
int[] arrayNumeros = new int[7] {100, 6, 3, 0, 8, 1, 9 };

var min = arrayNumeros.Min();
var max = arrayNumeros.Max();
//Pegar media dos numeros ACHEI LINDÃO
var medio = arrayNumeros.Average();
var soma = arrayNumeros.Sum();
var distintos = arrayNumeros.Distinct().ToArray();


// var resultado1 = 
//         from num in arrayNumeros
//         where num % 2 == 0
//         orderby num
//         select num;

// var resultado2 = arrayNumeros.Where(n => n % 2 == 0).OrderBy(x => x).ToList();


// Dictionary<string, string> estados = new Dictionary<string, string>{{"PR" , "Parana"}, {"MG" , "Minas Gerais"}};

// estados.Add("SP", "São Paulo");

// // foreach (KeyValuePair<string, string> item in estados)
// // {
// //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// // }

// var valorProcurado = "SP";

// if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
// {
//     System.Console.WriteLine(estadoEncontrado);
// }

// System.Console.WriteLine(estados[valorProcurado]);

// estados[valorProcurado] = "teste Atualização";

//estados.Remove(valorProcurado);

// using ExemploColecoes.Helper;

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string>{"SP", "MG", "BH"};
// string[] estadosArray = new string[2]{"SC", "Mt"};
// System.Console.WriteLine($"Quantidade de elentendo na lista {estados.Count}");

// //estados.AddRange(estadosArray);

// estados.Insert(1, "RJ");

// var removeu = estados.Remove("BH");

// if(removeu)
// {
//     opLista.ImprimirLista(estados);
// }

// using ExemploColecoes.Helper;

// OperacoesArray op = new OperacoesArray();

// int[] array = new int[5] { 6, 3, 8, 1, 9 };
// int[] arrayCopia = new int[10];

// int valorProcurado = 1;
// bool existe = op.Existe(array, valorProcurado);

// if(existe)
// {
//     System.Console.WriteLine($"Valor {valorProcurado} existe");
// }
// else{
//     System.Console.WriteLine($"Valor {valorProcurado} não existe");
// }

// System.Console.WriteLine("Array antes da copia");
// op.ImprimirArray(array);

// op.Copiar(ref array, ref arrayCopia);

// System.Console.WriteLine("Array depois da copia");
// op.ImprimirArray(array);

// System.Console.WriteLine("Array original");
// op.ImprimirArray(array);

// //op.OrdernarBubbleSort(ref array);
// //op.Ordernar(ref array);

// System.Console.WriteLine("Array Ordenado");
// op.ImprimirArray(array);

// int[,] matriz = new int [4,2]
// {  
//     {8, 8},{10, 20}, {50, 100}, {90, 200}
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         System.Console.WriteLine(matriz[i,j]);
//     }   
// }

// matrix[0,0] = 5;



// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");

// System.Console.WriteLine("Percorrendo o array pelo For ");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     System.Console.WriteLine(arrayInteiros[i]);
// }

// System.Console.WriteLine("Percorrendo o array pelo Foreach ");
// foreach (var item in arrayInteiros)
// {
//     System.Console.WriteLine(item);
// }