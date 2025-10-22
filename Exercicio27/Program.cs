int num;
int contador = 1;
int qtdUsuario;

Console.WriteLine("Quantas vezes você pretende repetir?");
qtdUsuario = int.Parse(Console.ReadLine());


while (contador <= qtdUsuario)
{
    Console.WriteLine("Digite um número par");
    num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine($"O seu número {num} é par");
    }
    else
    {
        Console.WriteLine($"O seu número não é par, tente novamente");
    }

    Thread.Sleep(1500);

    Console.Clear();

    contador++;
}