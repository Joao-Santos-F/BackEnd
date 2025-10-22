// Pedir para o usuário digitar dois números
// Em seguida verrificar e exibir qual é o maior dos dois números

using System.Runtime.InteropServices.Marshalling;

int n1, n2;

Console.WriteLine($"Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine($"O primeiro número é maior: {n1}");
}
if (n2 > n1)
{
    Console.WriteLine($"O segundo número é maior: {n2}");
}
else
{
    Console.WriteLine($"Os números são iguais: {n1} e {n2}");
}