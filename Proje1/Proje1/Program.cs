var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}s

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
<<<<<<< HEAD
=======
builder.WebHost.UseUrls("http://0.0.0.0:5000");
//fhýweurt
>>>>>>> 5a658d610d8fbf89f63bf35b50dabc055cb9380b
