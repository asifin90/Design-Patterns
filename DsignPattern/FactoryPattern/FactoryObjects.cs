using FactoryPattern.ConcretClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryObjects
    {
        ICalculate instance = null;
        public ICalculate getFactoyObject(string type)
        {
            if (type.ToLower()=="add")
            {
                instance = new Addition();
            }
            else if(type.ToLower() == "substract")
            {
                instance = new Substraction();
            }
            else if(type.ToLower() == "divide")
            {
                instance = new Divide();
            }
            else
            {
                throw new Exception("Type not matching, send correct type.");
            }
            return instance;
        }
    }
}
