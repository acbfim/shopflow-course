using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shopflow.contract.Model.Entities.Customer;
using shopflow.repository.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DefaultContext>(
    x => x.UseSqlite(builder.Configuration.GetConnectionString("default"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.Run();
