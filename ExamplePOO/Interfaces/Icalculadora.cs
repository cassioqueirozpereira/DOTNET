using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamplePOO.Interfaces
{
    public interface Icalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
            return num1 / num2;
        }
    }
}