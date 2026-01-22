using ReportSystem.Interfaces;

namespace ReportSystem.Services
{
    public class ReportGenerator : IReportGenerator
    {
        public string Generate()
        {
            return "Monthly Sales Report";
        }
    }
}
