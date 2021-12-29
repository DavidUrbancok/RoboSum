namespace RoboSum.Logging.MongoDB;

using global::MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using RoboSum.Logging.Abstractions;

/// <summary>
/// Represents a logger for logging messages to Mongo DB.
/// </summary>
public class MongoDbLoggerFactory : ILoggerFactory<LogItem>
{
    private readonly IMongoCollection<LogItem> _mongoCollection;

    /// <summary>
    /// Initializes a new instance of the <see cref="MongoDbLoggerFactory"/> class.
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

        _mongoCollection = database.GetCollection<LogItem>(collection);
    }

    /// <inheritdoc/>
    public ILogger<LogItem> Create()
    {
        return new MongoDbLogger<LogItem>(_mongoCollection);
    }
}
