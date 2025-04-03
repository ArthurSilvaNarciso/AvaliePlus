using AvalieMais.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

// Habilita sess�es
builder.Services.AddSession();

// Configura o Entity Framework com SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configura autentica��o por cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login"; // Redireciona para a tela de login se n�o autenticado
        options.LogoutPath = "/Account/Logout"; // Define a rota de logout
        options.AccessDeniedPath = "/Account/Login"; // Se o usu�rio n�o tiver permiss�o, redireciona para login
    });

builder.Services.AddAuthorization();

var app = builder.Build();

// Middleware
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication(); // Garante que a autentica��o seja aplicada antes da autoriza��o
app.UseAuthorization();
app.UseSession(); // Habilita suporte a sess�es

// Configura��o das rotas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}"); // Agora inicia no Login

app.Run();
