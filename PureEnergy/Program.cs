using Microsoft.EntityFrameworkCore;
using PureEnergy.Application.Interfaces;
using PureEnergy.Application.Services;
using PureEnergy.Infraestructure.Data.AppData;
using PureEnergy.Infraestruture.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<IClienteApplicationService, ClienteApplicationService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
