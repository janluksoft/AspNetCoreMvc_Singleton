using PMvcMyLay73.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//--- 2024-07-29 ---------
builder.Services.AddScoped<IUserService, UserService>();

//builder.Services.AddScoped<IStuffService, StuffService>(); //register
builder.Services.AddSingleton<IStuffServiceSingle, StuffServiceSingle>(); //register
builder.Services.AddTransient<IStuffService, StuffService>(); //register


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
