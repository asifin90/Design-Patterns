using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsignPattern
{
    // Singleton pattern used for creating object for the first time and 
    // reuse the same object throughout the application.
    public class SQLInstance
    {
        static SQLOperation objSQLOperation;

        public static SQLOperation CreateOrReuseObject()
        {
            if (objSQLOperation == null)
                objSQLOperation = new SQLOperation();
            return objSQLOperation;
        }
    }
}
