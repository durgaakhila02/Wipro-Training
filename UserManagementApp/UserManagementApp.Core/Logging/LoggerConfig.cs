using Serilog;

namespace UserManagementApp.Core.Logging
{
    public static class LoggerConfig
    {
        public static void Configure()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    "logs/app-log.txt",
                    rollingInterval: RollingInterval.Day)
                .CreateLogger();
        }
    }
}
