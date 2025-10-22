//Pedir para o usuário digitar dois números

using System.Runtime.InteropServices;

float Num1, Num2, Soma;

Console.WriteLine($"Escolha o primeiro número");
Num1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Escolha um segundo número");
Num2 = float.Parse(Console.ReadLine());

Soma = Num1 + Num2;

Console.WriteLine($"A soma de {Num1} + {Num2} é {Soma}");


