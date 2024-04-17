using System;
using Microsoft.EntityFrameworkCore;
using TAREALABO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ToDoContext>(options => options.UseSqlite(builder.Configuration["ConnectionStrings:SQLiteConnection"]));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#region Repositories
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IToDoItemRepository, ToDoItemRepository>();
#endregion

#region Services
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IToDoItemService, ToDoItemService>();
#endregion

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
