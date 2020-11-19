using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcretClasses
{
    public class Addition : ICalculate
    {
        public double calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
