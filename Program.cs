using Microsoft.EntityFrameworkCore;
using maps2.Models;
using maps2.Reporsitorio.Implementacion;
using maps2.Repositorios.Contrato;
using ProyectoLogin.Models;
using ProyectoLogin.Servicios.Implementacion;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DBMarkersContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IUsuarioService, UsuarioService>();

builder.Services.AddScoped<IGenericRepository<TipoPropiedad>, TipoPropiedadRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
