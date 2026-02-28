// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculadora");   

Console.WriteLine("digite o primeiro numero");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("digite o segundo numero");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("escolha a operaçao");
Console.WriteLine("1 - adiçao");
Console.WriteLine("2- subtraçao");
Console.WriteLine("3- multiplicaçao");
Console.WriteLine("4-divisao");
int operacao = Convert.ToInt32(Console.ReadLine());
switch (operacao)
{
    case 1:
        Console.WriteLine($"Resultado: {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"Resultado: {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"Resultado: {num1 * num2}");
        break;
    case 4:
        if (num2 != 0)
            Console.WriteLine($"Resultado: {num1 / num2}");
        else
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        break;
    default:
        Console.WriteLine("Operação inválida.");
        break;
}