namespace RoboSum.Logging.Abstractions;

/// <summary>
/// Represents a contract for logging messages to MongoDB.
/// </summary>
/// <typeparam name="TLogItem">The type of the item to log.</typeparam>
public interface ILogger<in TLogItem>
    where TLogItem : LogItem
{
    /// <summary>
    /// Logs the <paramref name="logItem"/> to the database.
    /// </summary>
    /// <param name="logItem">The item to log.</param>
    void Log(TLogItem logItem);

    /// <summary>
    /// Logs the <paramref name="logItems"/> to the database.
    /// </summary>
    /// <param name="logItems">The items to log.</param>
    void Log(IEnumerable<TLogItem> logItems);

    /// <summary>
    /// Asynchronously logs the <paramref name="logItem"/> to the database.
    /// </summary>
    /// <param name="logItem">The item to log.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task LogAsync(TLogItem logItem);

    /// <summary>
    /// Asynchronously logs the <paramref name="logItems"/> to the database.
    /// </summary>
    /// <param name="logItems">The items to log.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task LogAsync(IEnumerable<TLogItem> logItems);
}
