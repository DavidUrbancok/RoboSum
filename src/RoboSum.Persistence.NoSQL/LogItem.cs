namespace RoboSum.Logging.Abstractions;

using System.Text;

/// <summary>
/// Represents a single item to log to the database.
/// </summary>
public record LogItem
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogItem"/> class.
    /// </summary>
    /// <param name="message">The message to log.</param>
    public LogItem(string message)
    {
        Message = message;
        Timestamp = DateTime.UtcNow;
    }

    /// <summary>
    /// Gets the message to log.
    /// </summary>
    /// <value>
    /// The message to log.
    /// </value>
    public virtual string Message { get; }

    /// <summary>
    /// Gets the log item's creation date and time.
    /// </summary>
    /// <value>
    /// The log item's creation date and time.
    /// </value>
    public virtual DateTime Timestamp { get; }

    /// <summary>
    /// Gets the exception to log.
    /// </summary>
    /// <value>
    /// The exception to log.
    /// </value>
    public virtual Exception? Exception { get; init; }

    /// <inheritdoc/>
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        _ = stringBuilder.Append(Message);
        _ = stringBuilder.Append(Timestamp);

        if (Exception is not null)
        {
            _ = stringBuilder.Append(Exception);
        }

        return stringBuilder.ToString();
    }
}
