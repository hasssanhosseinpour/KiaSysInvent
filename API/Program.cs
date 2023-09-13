using API.Data;
using API.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

app.UseCors(builder=>builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
// Configure the HTTP request pipeline.

app.UseAuthentication(); // you have the token
app.UseAuthorization(); // what you allow to do

app.MapControllers();


// For seeding data
// This gives us access to all services we have inside this program class
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    var context = services.GetRequiredService<DataContext>();
    await context.Database.MigrateAsync();
    await Seed.SeedUsers(context);
    await Seed.SeedSupplier(context);
    await Seed.SeedUnitOfMeasure(context);
    await Seed.SeedItemCategory(context);
    await Seed.SeedItems(context);
    //await Seed.SeedPhoto(context);
    
}

catch(Exception ex)
{
    var logger = services.GetService<ILogger<Program>>();
    logger.LogError(ex,"An error occured during migration");

}

app.Run();
