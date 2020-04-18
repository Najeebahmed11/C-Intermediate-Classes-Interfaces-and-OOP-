using System;

namespace csharpintermediate
{
    public class DbCommand
    {
        private DbConnection _dbConnection { get; }
        public string Command { get; set; }
        public DbCommand(DbConnection dbConnection, string command)
        {
            if (String.IsNullOrEmpty(command))
                throw new InvalidOperationException("Invalid command!!");

            _dbConnection = dbConnection;
            Command = command;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(Command.ToUpper());
            _dbConnection.CloseConnection();
            Console.WriteLine($"Success!!!!!{Environment.NewLine}");
        }
    }
}