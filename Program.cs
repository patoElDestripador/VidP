using VidP.Data;
using Microsoft.EntityFrameworkCore;
using VidP.Services.Categories;
using VidP.Services.Customers;
using VidP.Services.Employees;
using VidP.Services.Movies;
using VidP.Services.Rentals;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BaseContext>(Options => Options.UseMySql(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient(); //Registra el servicio HttpClient en el contenedor de dependencias
builder.Services.AddControllers();//Registra los servicios necesarios para los controladores en el contenedor de dependencias.


builder.Services.AddScoped<ICategoriesService, CategoriesService>();
builder.Services.AddScoped<ICustomersService, CustomersService>();
builder.Services.AddScoped<IEmployeesService, EmployeesService>();
builder.Services.AddScoped<IMoviesService, MoviesService>();
builder.Services.AddScoped<IRentalsService, RentalsService>();



builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();


app.UseCors("AllowAnyOrigin");// activa los cors

app.MapControllers(); //configura las rutas para los controladores, permitiendo que las solicitudes HTTP entrantes sean manejadas por los controladores registrados.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

