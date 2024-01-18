// Logger class for displaying messages
public class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Logger] {message}");
    }
}

// This will depend on the Logger classs
public class ReportGenerator
{
    private readonly Logger logger;

    // Constructor injection: Logger is injected through the constructor
    public ReportGenerator(Logger logger)
    {
        this.logger = logger;
    }

    public void GenerateReport()
    {
        // Generating report logic
        logger.Log("Generating report...");

        // Simulating report generation
        Console.WriteLine("Report generated successfully!");
    }
}

// Application entry point
class Program
{
    static void Main()
    {
        Logger logger = new Logger();

        // Dependency Injection: Inject Logger into ReportGenerator
        ReportGenerator reportGenerator = new ReportGenerator(logger);

        // Using the ReportGenerator to generate a report
        reportGenerator.GenerateReport();
    }
}
