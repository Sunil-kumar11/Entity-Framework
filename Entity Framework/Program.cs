using Entity_Framework.Interfaces;
using Entity_Framework.Managers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IBank, Icici>();
builder.Services.AddScoped<IBank,SBI>();
builder.Services.AddScoped(typeof(CustomMiddleware));
builder.Services.AddControllers();

var app = builder.Build();
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
