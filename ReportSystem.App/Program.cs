using ReportSystem.Interfaces;
using ReportSystem.Services;
using ReportSystem.Formatters;

IReportGenerator generator = new ReportGenerator();
IReportFormatter formatter = new PdfFormatter();
IReportSaver saver = new FileReportSaver();

var service = new ReportService(generator, formatter, saver);
Console.WriteLine("SOLID Principles Demo");
service.Process();
