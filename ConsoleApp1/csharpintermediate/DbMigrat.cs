using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace csharpintermediate
{
    public class DbMigrat
    {
        private readonly ILogger _logger;

        public DbMigrat(ILogger logger)
        {
            this._logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
            //details of migrating the database
        }
    }
}

