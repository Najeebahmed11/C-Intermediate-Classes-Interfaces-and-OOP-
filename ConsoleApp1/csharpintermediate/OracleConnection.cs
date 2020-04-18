using System;

namespace csharpintermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("-----------Oracle DB connection Established-----------");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"-----------Oracle DB connection closed-----------");
        }
    }
}