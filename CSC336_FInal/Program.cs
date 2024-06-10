using BLL.Wrapping.Exceptions;
using CSC336_FInal.Extenstions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

//Mapping
builder.Services.AutoMappingConfig();
//DBContext
builder.Services.AddDB(builder.Configuration);
//Repository D
builder.Services.AddRepositories();
//Service D
builder.Services.AddServices();
//Exceptions
builder.Services.AddExeptionService();
builder.Services.AddSingleton<IExceptionHandler, GlobalExceptionHandler>();

//Logger
builder.Services.AddLogging(logging =>
{
    // Configure logging options here
});


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
}
app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
