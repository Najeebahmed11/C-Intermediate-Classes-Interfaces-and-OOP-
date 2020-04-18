using ClassLibrary1;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System;
namespace csharpintermediate
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Sealed classes are the oppiste of abstract classes
            //prevent derivation of classes
            //sealed is only applied to virtual with override methods
            //
            var sqlDbConnection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB");
            var sqlDbQuery = "USE my-DB; SELECT * FROM connections";
            var sqlDbCommand = new DbCommand(sqlDbConnection, sqlDbQuery);

            sqlDbCommand.Execute();

            var oracleDbConnection = new OracleConnection(@"Data Source=(LocalDb)\MSSQLLocalDB");
            var oracleDbQuery = "USE my-DB; SELECT * FROM connections";
            var oracleDbCommand = new DbCommand(oracleDbConnection, oracleDbQuery);

            oracleDbCommand.Execute();

            Console.ReadLine();
        }

    }       
}

