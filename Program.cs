using System.Reflection;
using AutoMapper;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Application.Mapping;
using ITM_Server.Persistance.Context;
using ITM_Server.Persistance.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ItmContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
    
} );
builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>()
    {
        new ActivationProfile()
    });

    opt.AddProfiles(new List<Profile>()
    {
        new VaryantProfile()
    });
 

    
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();