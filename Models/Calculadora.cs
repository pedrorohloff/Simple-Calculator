using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraCientifica.Interfaces;

namespace CalculadoraCientifica.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            if(num2 == 0)
            {
                Console.WriteLine("Error! Cannot divide by 0");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}