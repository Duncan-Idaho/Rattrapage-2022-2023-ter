using System.Diagnostics;

namespace Question07.Console;

public class Logger
{
    private readonly TextWriter logger;
    private readonly Stopwatch stopwatch;

    public Logger(TextWriter logger)
    {
        this.logger = logger;
        stopwatch = new Stopwatch();
        stopwatch.Start();
    }

    public long RoundedEllapsedMinutes
        => stopwatch.ElapsedMilliseconds / 100;

    public void Log(string logLine)
        => logger.WriteLine($"[T + {RoundedEllapsedMinutes:D3}] {logLine}");
}
