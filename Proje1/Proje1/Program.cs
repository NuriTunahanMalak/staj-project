using Proje1.Data.Contexts;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Proje1DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("stajDBConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
<<<<<<< HEAD

builder.WebHost.UseUrls("http://0.0.0.0:5000");

=======
<<<<<<< HEAD

builder.WebHost.UseUrls("http://0.0.0.0:5000");

=======
builder.WebHost.UseUrls("http://0.0.0.0:5000");
>>>>>>> c804210bad16bd9b92b95b811f0024e8346d2839
>>>>>>> 338d316bde123df132d7d729c7f62f20ee8758df
