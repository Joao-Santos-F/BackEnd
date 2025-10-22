int cargo;
double salario;
double aumento1, aumento2, aumento3;

Console.WriteLine("Qual é o seu cargo no momento?");
Console.WriteLine("1 - Producao");
Console.WriteLine("2 - administracao");
Console.WriteLine("3 - diretoria");
cargo = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu salário no momento?");
salario = int.Parse(Console.ReadLine());

aumento1 = salario * 0.065;
aumento2 = salario * 0.075;
aumento3 = salario * 0.120;

if (cargo == 1)
{
    Console.WriteLine($"O seu salário de {salario} agora é de {aumento1} ");
}
else if (cargo == 2)
{
    Console.WriteLine($"O seu salário de {salario} agora é de {aumento2} ");
}
else if (cargo == 3)
{
    Console.WriteLine($"O seu salário de {salario} agora é de {aumento3} ");
}
else
{
    Console.WriteLine("Este cargo náo está recebendo aumento no momento");
}