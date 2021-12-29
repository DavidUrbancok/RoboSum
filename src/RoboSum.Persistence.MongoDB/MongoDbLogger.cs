namespace RoboSum.Logging.MongoDB;

using global::MongoDB.Driver;
using RoboSum.Logging.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Represents a logger for logging messages to Mongo DB.
/// </summary>
/// <typeparam name="TLogItem">The type of the log items to save.</typeparam>
public class MongoDbLogger<TLogItem> : ILogger<TLogItem>
    where TLogItem : LogItem
{
    private readonly IMongoCollection<TLogItem> _collection;

    /// <summary>
    /// Initializes a new instance of the <see cref="MongoDbLogger{TLogItem}"/> class.
    /// </summary>
    /// <param name="collection">The Mongo collection to which to save the logs.</param>
    /// <exception cref="ArgumentNullException">Thrown, when <paramref name="collection"/> is <see langword="null"/>.</exception>
    public MongoDbLogger(IMongoCollection<TLogItem> collection)
    {
        _collection = collection ?? throw new ArgumentNullException(nameof(collection));
    }

    /// <inheritdoc/>
    public void Log(TLogItem logItem)
    {
        _collection.InsertOne(logItem);
    }

    /// <inheritdoc/>
    public void Log(IEnumerable<TLogItem> logItems)
    {
        _collection.InsertMany(logItems);
    }

    /// <inheritdoc/>
    public async Task LogAsync(TLogItem logItem)
    {
        await _collection.InsertOneAsync(logItem);
    }

    /// <inheritdoc/>
    public async Task LogAsync(IEnumerable<TLogItem> logItems)
    {
        await _collection.InsertManyAsync(logItems);
    }
}
