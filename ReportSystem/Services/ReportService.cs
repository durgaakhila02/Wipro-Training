using ReportSystem.Interfaces;

namespace ReportSystem.Services
{
    public class ReportService
    {
        private readonly IReportGenerator _generator;
        private readonly IReportFormatter _formatter;
        private readonly IReportSaver _saver;

        public ReportService(
            IReportGenerator generator,
            IReportFormatter formatter,
            IReportSaver saver)
        {
            _generator = generator;
            _formatter = formatter;
            _saver = saver;
        }

        public void Process()
        {
            var report = _generator.Generate();
            var formatted = _formatter.Format(report);
            _saver.Save(formatted);
        }
    }
}
