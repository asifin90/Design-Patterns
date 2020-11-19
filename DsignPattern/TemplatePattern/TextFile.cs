using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern.AbstractMember;

namespace TemplatePattern
{
    public class TextFile : Template
    {
        public override void ProcessData()
        {
            Console.WriteLine("Read text file data");
        }

        public override void ReadData()
        {
            Console.WriteLine("Text file data is processing");
        }
    }
}
