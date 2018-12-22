using System;

namespace Calculadora
{
    class Calculator
    {
        public double oper1;
        public double oper2;
        private double result;

        public Calculator(double v1, double v2)
        {
            oper1 = v1;
            oper2 = v2;
        }
        public double Suma()
        {
            result = oper1 + oper2;
            return result;
        }
            
    }
}
