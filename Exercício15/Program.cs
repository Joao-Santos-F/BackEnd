float n1, n2, n3, n4, media;

Console.WriteLine($"qual sua primeira nota?");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"qual sua segunda nota?");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine($"qual sua terceira nota?");
n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"qual sua quarta nota?");
n4 = float.Parse(Console.ReadLine());

media = (n1 + n2 + n3 + n4) / 4;

Console.Clear();

if (media > 7.0)
{
    Console.WriteLine($"Aprovado, sua média foi {media}");
}
else if (media >= 5.5 && media <= 7.0)
{
    Console.WriteLine($"Recuperacao, sua média foi {media}");
}
else
{
    Console.WriteLine($"Reprovado, sua média foi {media}");
}

System.Threading.Thread.Sleep(15000);

Console.Clear();