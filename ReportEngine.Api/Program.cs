using Microsoft.EntityFrameworkCore;
using ReportEngine.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Default"),
        npgsqlOptions =>
        {
            npgsqlOptions.UseQuerySplittingBehavior(
                QuerySplittingBehavior.SplitQuery
            );
        });
});

var app = builder.Build();

// pipeline

app.Run();