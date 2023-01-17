using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BuberBreakfast.Services.Breakfasts;
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService,BreakfastService>();
}

var app = builder.Build();
{
app.UseHttpsRedirection();

app.MapControllers();

app.Run();

}


