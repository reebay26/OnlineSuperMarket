using Microsoft.EntityFrameworkCore;
using OnlineSuperMarket.Dbwork;
using OnlineSuperMarket.seeder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(
   options =>
   {
       options.IdleTimeout = TimeSpan.FromDays(30); 
       options.Cookie.HttpOnly = true;
       options.Cookie.IsEssential = true;
   }
    );

builder.Services.AddDbContext<sqlDb>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
});

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
  
        var dbContext = services.GetRequiredService<sqlDb>();
        var env = services.GetRequiredService<IWebHostEnvironment>();
        var seeder = new DatabaseSeeder(dbContext, env);
        seeder.Seed();

  
}


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
app.UseSession();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=web}/{action=Home}/{id?}");


app.Run();
