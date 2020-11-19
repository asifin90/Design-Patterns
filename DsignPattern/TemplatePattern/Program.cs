using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile objExcel = new ExcelFile();
            objExcel.ReadProcessAndSave();

            TextFile objTextFile = new TextFile();
            objTextFile.ReadProcessAndSave();

            Console.ReadLine();
        }
    }
}
