using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.SqlClient;

namespace ExtentionMethodenWithLinqNamespace
{
    class Program
    {

        public void DBKlassen()
        {
            //abstraction Schicht ab .NET 1.1 / 2.0
            //DbConnection
            //DbCommand
            //DbDataReader

            //SQLClient
            //SqlConnection 
            //SqlCommand
            //SqlDataReader = Sequentielles auslesen (hat 'wenig' Metadaten)
            //SqlDataAdapter = es ist langsamer als SqlDataReader, hat allerdins mehr Metainformation, bzw TabellenSchema

            //OracleClient
            //OracleConnection
            //OracleCommand ... 

        }
        static void Main(string[] args)
        {
            IList<int> intList = new List<int>();
        }
    }
}
