using Microsoft.EntityFrameworkCore;
using MvcWithSQLite.Models;
using MvcWithSQLite.Data;


var builder = WebApplication.CreateBuilder(args);

// Agrega el servicio del contexto de base de datos con SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=mi_base_de_datos.db"));

// Agrega controladores con vistas (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura las rutas
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
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
