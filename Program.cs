

using CalculadoraCientifica.Interfaces;
using CalculadoraCientifica.Models;

// Console.WriteLine("Digite o primeiro numero: ");
// int numero1 = Convert.ToInt32(Console.ReadLine()); // forma de ler numero e transformar para inteiro usando convert
// numero1 = int.Parse(Console.ReadLine()); // forma de ler numero e transformar entrada para inteiro usando parse
// Console.WriteLine("Digite o segundo numero: ");
// int numero2 = Convert.ToInt32(Console.ReadLine());

internal class Program
{
    private static void Main(string[] args)
    {
        ICalculadora calculo = new Calculadora();  // instanciamento da classe calculadora



        var opcao = '0';

        do
        {
            // quebrou o codigo
            // ver como implementar TryParse-
            Console.WriteLine("Digite a operação desejada: ");
            opcao = Convert.ToChar(Console.ReadLine().ToUpper());
            
            if (opcao == 'X')
            {
                break;
            }

            Console.WriteLine("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
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
                case 'X':
                    break;
                default:
                    Console.WriteLine("Insira uma operação válida.");
                    break;
            }
        } while (opcao != 'X');
    }
}