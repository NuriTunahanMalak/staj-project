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
<<<<<<< HEAD

builder.WebHost.UseUrls("http://0.0.0.0:5000");

=======
<<<<<<< HEAD
=======
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 67cf4dee86e1d063e8f7e87aead23ce35461f4a8

builder.WebHost.UseUrls("http://0.0.0.0:5000");

=======
builder.WebHost.UseUrls("http://0.0.0.0:5000");
>>>>>>> c804210bad16bd9b92b95b811f0024e8346d2839
<<<<<<< HEAD
>>>>>>> 338d316bde123df132d7d729c7f62f20ee8758df
=======
=======
<<<<<<< HEAD
builder.WebHost.UseUrls("http://0.0.0.0:5000");
=======
>>>>>>> 0d557a1c54581a2c8dc8fb13fa3347498a19ed33

builder.WebHost.UseUrls("http://0.0.0.0:5000");


builder.WebHost.UseUrls("http://0.0.0.0:5000");

<<<<<<< HEAD


builder.WebHost.UseUrls("http://0.0.0.0:5000");
=======
>>>>>>> e5aa2baacd42a5d095f13a108a2e49fca17550d4
>>>>>>> f4288c7e7fd81f641d76df38147d5d5b14ae3ab1
>>>>>>> 0d557a1c54581a2c8dc8fb13fa3347498a19ed33
>>>>>>> 67cf4dee86e1d063e8f7e87aead23ce35461f4a8
