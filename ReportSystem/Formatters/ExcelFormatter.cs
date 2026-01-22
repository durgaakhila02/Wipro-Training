using ReportSystem.Interfaces;

namespace ReportSystem.Formatters
{
    public class ExcelFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return $"[EXCEL] {content}";
        }
    }
}
