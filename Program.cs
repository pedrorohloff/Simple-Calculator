

using CalculadoraCientifica.Interfaces;
using CalculadoraCientifica.Models;

Console.WriteLine("Digite o primeiro numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

ICalculadora calculo = new Calculadora();


Console.WriteLine("Digite a operação desejada: ");
var opcao = Convert.ToChar(Console.ReadLine());



switch (opcao)
{
    case '+':
        Console.WriteLine(calculo.Somar(numero1, numero2));
        break;
    case '-':
        Console.WriteLine(calculo.Subtrair(numero1, numero2));
        break;
    case '*':
        Console.WriteLine(calculo.Multiplicar(numero1, numero2));
        break;
    case '/':
        Console.WriteLine(calculo.Dividir(numero1, numero2));
        break;
    default:
        Console.WriteLine("Insira uma operação válida.");
        break;
}



