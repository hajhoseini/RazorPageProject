using Microsoft.EntityFrameworkCore;
using RazorPageProject.Models.Data;
using RazorPageProject.Models.Filters;
using RazorPageProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
                .AddMvcOptions(options =>
                {
                    options.Filters.Add(new MyPageFilter());
                })
                .AddRazorPagesOptions(optins =>
                {
                    //optins.RootDirectory = "/Content";
                });

builder.Services.AddDbContext<DataBaseContext>(
                                                options => options.UseSqlServer(
                                                    builder.Configuration["ConnectionStrings:ShoppingConnectionString"]));
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.Configure<RouteOptions>(options => 
                            { 
                                options.LowercaseUrls = true;
                                options.LowercaseQueryStrings = true;
                            });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
