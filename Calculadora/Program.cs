Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("-----BEM VINDO(A)-----");
    Console.WriteLine("(1) Soma");
    Console.WriteLine("(2) Subtração");
    Console.WriteLine("(3) Divisão");
    Console.WriteLine("(4) Multiplicação");
    Console.WriteLine("(5) Sair");
    Console.WriteLine("");
    Console.WriteLine("-----Digite o número referente a opção desejada-----");
    short opcao = short.Parse(Console.ReadLine());

    switch(opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 + valor2;
    Console.WriteLine($"O resultado da soma é: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Digite um número:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro número:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 - valor2;

    Console.WriteLine($"O resultado da subtração entre os valores {valor1} e {valor2} é: {resultado}");
    
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 / valor2;

    Console.WriteLine($"Quociente: {resultado}");

    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite um valor:");
    float valor1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite outro valor:");
    float valor2 = float.Parse(Console.ReadLine());

    float resultado = valor1 * valor2;

    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    
    Console.ReadKey();
    Menu();
}