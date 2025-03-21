using Microsoft.EntityFrameworkCore;
using Talent_SV.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();


var serverVersion = new MySqlServerVersion(new Version(8, 0, 40));
builder.Services.AddDbContext<TalentContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("mysqlConnection"), serverVersion)
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();


app.Run();