using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.AbstractMember;

namespace TemplatePattern
{
    public class ExcelFile : Template
    {
        public override void ProcessData()
        {
            Console.WriteLine("Read Excel file data");
        }

        public override void ReadData()
        {
            Console.WriteLine("Excel file data is processing");
        }
    }
}
