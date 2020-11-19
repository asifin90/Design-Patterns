using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcretClasses
{
    public class Substraction : ICalculate
    {
        public double calculate(double number1, double number2)
        {
            return number1 - number2;
        }
    }

    public class Divide : ICalculate
    {
        public double calculate(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
