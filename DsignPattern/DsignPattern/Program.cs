using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            Program obj1 = new Program();
            obj.GetAllRecord();
            obj.InsertRecord();            
            Console.ReadLine();
        }

        public void GetAllRecord()
        {
            // If SQLOperation  already created it will reuse
            SQLOperation objSQLInstance = SQLInstance.CreateOrReuseObject();
            objSQLInstance.GetRecordsFromDB();
            Console.WriteLine(objSQLInstance.GetHashCode());
        }

        public void InsertRecord()
        {
            // If SQLOperation  already created it will reuse
            SQLOperation objSQLInstance = SQLInstance.CreateOrReuseObject();
            objSQLInstance.InsertRecordIntoDB();
            Console.WriteLine(objSQLInstance.GetHashCode());
        }
    }
}
