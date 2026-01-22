using System;
using System.IO;

namespace DesignPatternsAssignment.Singleton
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private static readonly string logFilePath = "app.log";

        // Private constructor
        private Logger() { }

        // Global access point
        public static Logger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            string logMessage = $"[{DateTime.Now}] {message}";

            // Show in terminal
            Console.WriteLine(logMessage);

            // Write to log file
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }
    }
}
