using ReportSystem.Interfaces;

namespace ReportSystem.Services
{
    public class FileReportSaver : IReportSaver
    {
        public void Save(string content)
        {
            Console.WriteLine("Report saved Sucessfully");
        }
    }
}
