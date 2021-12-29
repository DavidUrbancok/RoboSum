namespace RoboSum.API;

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

        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        app.Run();
    }

    private static WebApplicationBuilder ConfigureServices(WebApplicationBuilder builder)
    {
        var services = builder.Services;

        // Add services to the container.
        _ = services.AddControllers();
        _ = services.AddDbContext<AbstractDbContext>();

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

    private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
    }
}
