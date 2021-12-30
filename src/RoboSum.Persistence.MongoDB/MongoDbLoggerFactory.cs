namespace RoboSum.Logging.MongoDB;

using global::MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using RoboSum.Logging.Abstractions;

/// <summary>
/// Represents a logger for logging messages to Mongo DB.
/// </summary>
/// <typeparam name="TLogItem">The type of the log item.</typeparam>
public class MongoDbLoggerFactory<TLogItem> : ILoggerFactory<TLogItem>
    where TLogItem : LogItem
{
    private readonly IMongoCollection<TLogItem> _mongoCollection;

    /// <summary>
    /// Initializes a new instance of the <see cref="MongoDbLoggerFactory{TLogItem}"/> class.
    /// </summary>
    public MongoDbLoggerFactory()
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("mongo.json").Build();

        var username = configuration["auth:username"];
        var password = configuration["auth:password"];
        var clusterAddress = configuration["clusterAddress"];

        var client = new MongoClient($"mongodb+srv://{username}:{password}@{clusterAddress}/");

        var databaseName = configuration["db:database"];
        var collection = configuration["db:collection"];

        var database = client.GetDatabase(databaseName);

        _mongoCollection = database.GetCollection<TLogItem>(collection);
    }

    /// <inheritdoc/>
    public ILogger<TLogItem> Create()
    {
        return new MongoDbLogger<TLogItem>(_mongoCollection);
    }
}
