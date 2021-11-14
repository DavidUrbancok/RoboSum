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
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        WebApplication app = ConfigureServices(builder).Build();

        Configure(app);

        app.Run();
    }

    private static WebApplicationBuilder ConfigureServices(WebApplicationBuilder builder)
    {
        IServiceCollection services = builder.Services;

        // Add services to the container.
        services.AddControllers();
        services.AddDbContext<AbstractDbContext>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return builder;
    }

    private static void Configure(WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
    }
}
