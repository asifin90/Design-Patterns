using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        ICalculate instance = null;
        FactoryObjects factoryObject = new FactoryObjects();
        static void Main(string[] args)
        {
            Console.WriteLine("Factory pattern");
            Program p = new Program();
            p.Addition();
            p.Substraction();
            p.Divide();
            Console.ReadLine();
        }

        public void Addition()
        {
            instance = factoryObject.getFactoyObject("Add");
            Console.WriteLine(instance.calculate(2, 3));
        }
        public void Substraction()
        {
            instance = factoryObject.getFactoyObject("substract");
            Console.WriteLine(instance.calculate(5.5,4.1));
        }
        public void Divide()
        {
            instance = factoryObject.getFactoyObject("divide");
            Console.WriteLine(instance.calculate(9,3.0));
        }
    }
}
