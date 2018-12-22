using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ejemplo de uso

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculadora = new Calculator(10,20);
            Console.WriteLine("Resultado: {0}", calculadora.Suma());
            Console.ReadKey();
        }
    }
}
