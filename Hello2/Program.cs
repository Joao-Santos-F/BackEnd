// Pedir para o usuário digitar o nome, sobrenome, idade, saldo bancário e quanto investiu

//Camel Case - Letra maiúscula apartir da segunda palavra
string nome;
string sobrenomeDoFulano;
int idade;
float saldoBancario;
float investimentos;

Console.WriteLine("Olá, Qual é o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual é o seu sobrenome?");
sobrenomeDoFulano = Console.ReadLine();

Console.WriteLine("Qual a sua idade?");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu saldo bancário?");
saldoBancario = float.Parse(Console.ReadLine());

Console.WriteLine("Qual é o seu investimento?");
investimentos = float.Parse(Console.ReadLine());

Console.Clear(); //limpa o console

Console.WriteLine($"Seu nome é {nome} {sobrenomeDoFulano}");
Console.WriteLine($"Idade de {nome} é {idade} ");
Console.WriteLine($"Seu saldo bancário é de R${saldoBancario}");
Console.WriteLine($"Seus investimentos este ano foi R${investimentos}");