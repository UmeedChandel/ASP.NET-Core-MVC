using Microsoft.AspNetCore.Identity; // <<<<<<<<============
using Microsoft.EntityFrameworkCore;
using PieWorkShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Connection String
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connString);
});

//Identity
builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>(); // <<<<<<<<============

// Add services to the container.
builder.Services.AddControllersWithViews();

// Dependencies injection
builder.Services.AddRazorPages(); // <<<<<<<<============
builder.Services.AddScoped<IPieRepository, MockPieData>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryData>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryData>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();

// builder.Services.AddHttpContextAccessor(); // <<== needed for getting user info


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

app.UseAuthentication(); // <<<<<<<<============
app.UseAuthorization();

// Convention-based routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages(); // <<<<<<<<============

app.Run();
