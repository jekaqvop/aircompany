using Serilog;
using System;
using System.IO;

namespace AvatradeTests.Utils
{
    class Log
    {
        static Log()
        {
            File.Delete("../../../Logs/PocketOptionsTests.log");
            Serilog.Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.File("../../../Logs/PocketOptionsTests.log", outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
        }

        public static void Info(string message)
        {
            Serilog.Log.Information(message);
        }
    }
}
