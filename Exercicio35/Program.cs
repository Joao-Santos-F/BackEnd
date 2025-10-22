int repeticoes = 1;
int repusr;
int num1, num2;

Console.WriteLine("Digite a quantidade de repetições que você deseja");
repusr = int.Parse(Console.ReadLine());

while (repeticoes <= repusr)
{

    Console.WriteLine($"Você escolheu {repusr} repetições");

    Console.WriteLine("Digite seu primeiro número");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu segundo número");
    num2 = int.Parse(Console.ReadLine());

    Console.Clear();

    if (num1 > num2)
    {
        Console.WriteLine($"O número {num1} é maior que o número {num2}");
    }
    else if (num1 < num2)
    {
        Console.WriteLine($"O número {num1} é menor que o número {num2}");
    }
    else
    {
        Console.WriteLine($"O número {num1} e número {num2} são iguais");
    }

    Thread.Sleep(2000);

    Console.Clear();

    repeticoes++;
}