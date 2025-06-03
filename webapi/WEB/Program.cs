using BL.classes;
using BL.interfaces;
using DAL.classes;
using DAL.interfaces;
using DAL.models;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//category
builder.Services.AddScoped<IcategoryDAL, CategoryDAL>();
builder.Services.AddScoped<IcategoryBL, categoryBL>();
//Customer
builder.Services.AddScoped<ICustomerDAL, CustomerDAL>();
builder.Services.AddScoped<IcustomerBL, CustomerBL>();
//Game
builder.Services.AddScoped<IGameDAL, GameDAL>();
builder.Services.AddScoped<IGameBL, GameBL>();
//information
builder.Services.AddScoped<IinformationDAL, InformationDAL>();
builder.Services.AddScoped<IinformationBL,informationBL >();
//shopping
builder.Services.AddScoped<IShoppingDAL, ShoppingDAL>();
builder.Services.AddScoped<IShoppingBL, ShoppingBL>();

    //casting
//mapper
builder.Services.AddAutoMapper(typeof(Program));
//sql server
builder.Services.AddDbContext<Game_storeContext>
    (options => options.UseSqlServer("Scaffold-DbContext \"Data Source=MC-CLD3CZYSQMXO\\SQLEXPRESS;Initial Catalog=Game_store;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir models\r\n"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //belong to react
    app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();

app.Run();