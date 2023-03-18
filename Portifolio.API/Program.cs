using Portifolio.API.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();


app.MapPost("/", (Contact contact) =>
{
   
})
.WithOpenApi();

app.Run();

//34minutos 
