// Configure LOG4NET Using configuration file.
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace MsSqlToSqlLiteConverter
{
    using System;
    using System.Collections.Generic;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(params string[]args)
        {
            SqlServerToSQLite.ConvertSqlServerDatabaseToSqLiteFile(args[0], Guid.NewGuid() + ".db", args[1], null, new List<string>(args[2].Split(',')), null, null, null,false);
        }
    }
}