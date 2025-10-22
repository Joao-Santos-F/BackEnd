Console.WriteLine("Quantos número voce quer digitar?");
int qtdNumeros = int.Parse(Console.ReadLine());

string pares = "Pares: ";
string impares = "Impares: ";

for (int i = 1; i <= qtdNumeros; i++)
{
    Console.WriteLine($"Digite o {i}º número");
    int NumeroDigitado = int.Parse(Console.ReadLine());

    if (NumeroDigitado % 2 == 0)
    {
        pares += NumeroDigitado.ToString() + ", ";
    }
    else
    {
        impares += NumeroDigitado.ToString() + ", ";
    }
}

Console.Clear();

Console.WriteLine($"RESULTADO");
Console.WriteLine($"");
Console.WriteLine(pares);
Console.WriteLine($"");
Console.WriteLine(impares);