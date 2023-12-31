using FinalProject_Team9;
using FinalProject_Team9.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerDocument();

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TeamContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TeamContext")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseOpenApi();
app.UseSwaggerUi3();
app.UseRouting();
app.UseAuthorization();
context.Database.Migrate();
app.MapControllers();

app.Run();
