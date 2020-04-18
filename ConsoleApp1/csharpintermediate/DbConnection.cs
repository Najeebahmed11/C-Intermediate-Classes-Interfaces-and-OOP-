
 
using System;

namespace csharpintermediate
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new Exception("Connection string can't be null or empty");

            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}