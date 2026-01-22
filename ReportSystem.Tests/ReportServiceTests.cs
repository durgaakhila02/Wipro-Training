using ReportSystem.Services;
using ReportSystem.Interfaces;
using ReportSystem.Formatters;
using Xunit;

public class ReportServiceTests
{
    [Fact]
    public void ReportGeneration_ShouldNotBeNull()
    {
        IReportGenerator generator = new ReportGenerator();
        var result = generator.Generate();

        Assert.NotNull(result);
    }
}
