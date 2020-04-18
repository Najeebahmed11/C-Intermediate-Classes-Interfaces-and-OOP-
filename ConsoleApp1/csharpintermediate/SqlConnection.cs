
 
using System;

namespace csharpintermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("-----------SQL Connection Established-----------");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"-----------SQL Connection closed-----------");

        }
    }
}