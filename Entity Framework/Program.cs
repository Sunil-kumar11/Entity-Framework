using Entity_Framework.context;
using Entity_Framework.Interfaces;
using Entity_Framework.Managers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IBank, Icici>();
builder.Services.AddScoped<IBank,SBI>();
builder.Services.AddScoped(typeof(CustomMiddleware));
builder.Services.AddControllers();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("common")));

var app = builder.Build();
app.UseDefaultFiles();
app.MapControllers();
app.UseStaticFiles();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=BankManager}/{action=testmethod}");
//});
//app.MapGet("/", () => "Hello World!");
//app.UseMiddleware<CustomMiddleware>();


app.Run();
