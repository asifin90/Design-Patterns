using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern.AbstractMember
{
    public abstract class Template
    {
        // This method decide execution of methods in sequence.
        // This method is also commeon in both Excel and test file
        public void ReadProcessAndSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        // Will create abstract method if it wil differe based on excel and text file.
        public abstract void ReadData();

        public abstract void ProcessData();

        // This method is also commeon in both Excel and test file
        public void SaveData()
        {
            Console.WriteLine("Save data to database");
        }
    }
}
