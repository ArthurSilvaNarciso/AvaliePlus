var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession(); // Habilita a sess�o

var app = builder.Build();
builder.Services.AddSession();
app.UseSession();

app.UseSession(); // Usa a sess�o
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

