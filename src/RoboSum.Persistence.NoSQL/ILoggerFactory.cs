namespace RoboSum.Logging.Abstractions;

/// <summary>
/// Represents a contract for creating instances of a logger.
/// </summary>
/// <typeparam name="TLogItem">The type of the log item.</typeparam>
public interface ILoggerFactory<in TLogItem>
    where TLogItem : LogItem
{
    /// <summary>
    /// Creates a logger for a log item of <typeparamref name="TLogItem"/> type.
    /// </summary>
    /// <returns>A new instance of the logger.</returns>
    ILogger<TLogItem> Create();
}
