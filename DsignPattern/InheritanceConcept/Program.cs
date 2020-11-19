using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{

    public class A
    {
        public void MA()
        {
            Console.WriteLine("M-A");
        }
        public virtual void MAOverride()
        {
            Console.WriteLine("M-A override");
        }
    }

    public class B:A
    {
        public void MB()
        {
            Console.WriteLine("M-B");
        }

        public override void MAOverride()
        {
            Console.WriteLine("M-AB override");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A objA = new A();
            objA.MA();

            B objB = new B();
            objB.MB();

            A objA1 = new B();
            objA1.MAOverride();
            Console.WriteLine("After casting of object");
            B objB1 = (B)objA1;
            objB1.MA();
            objB1.MAOverride();
            objB1.MB();
            Console.ReadLine();
        }
    }
}
