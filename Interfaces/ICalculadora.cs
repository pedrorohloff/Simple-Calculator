using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraCientifica.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2); 
        int Multiplicar(int num1, int num2); 
        double Dividir(double num1, double num2);
    }
}