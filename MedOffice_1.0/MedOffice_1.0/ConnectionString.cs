using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MedOffice_1._0
{
    public static class OurConnection
    {
        //Edit and add your connection to the DB here
        private static string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xdark\Documents\CST-227-CLC-Project\MedOfficeDB.accdb;
                                     Persist Security Info=False;";
        
        //Get and Set for connection string
        public static string Conn
        {
            get
            {
                return conn;
            }
            set
            {
                conn = value;
            }
        }
    }
}
