namespace RoboSum.API;

using Persistence.SQL;
using RoboSum.Logging.Abstractions;
using RoboSum.Logging.MongoDB;
using RoboSum.Persistence;

/// <summary>
/// Represents the web application's base class.
/// </summary>
public static class Program
{
    /// <summary>
    /// The web application's entry point.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = ConfigureServices(builder).Build();

        Configure(app);

        app.Run();
    }

    private static WebApplicationBuilder ConfigureServices(WebApplicationBuilder builder)
    {
        var services = builder.Services;

        // Add services to the container.
        _ = services.AddControllers();
        _ = services.AddDbContext<AbstractDbContext>();

        _ = services.AddTransient<ILogger<LogItem>, MongoDbLogger<LogItem>>();
        _ = services.AddTransient<ILoggerFactory<LogItem>, MongoDbLoggerFactory<LogItem>>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = services.AddEndpointsApiExplorer();
        _ = services.AddSwaggerGen();

        return builder;
    }

    private static void Configure(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            _ = app.UseDeveloperExceptionPage();
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();
        }

        _ = app.UseHttpsRedirection();
        _ = app.UseAuthorization();
        _ = app.MapControllers();
    }
}
