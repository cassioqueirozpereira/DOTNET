using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamplePOO.Interfaces;

namespace ExamplePOO.Models
{
    public class Calculadora : Icalculadora
    {
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