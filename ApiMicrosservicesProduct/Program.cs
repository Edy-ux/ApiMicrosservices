
using ApiMicrosservicesProduct.Dtos;
using ApiMicrosservicesProduct.Endpoints;
using ApiMicrosservicesProduct.Extensions;
using ApiMicrosservicesProduct.Extensions.endpoints;
using ApiMicrosservicesProduct.Services;
using ApiMicrosservicesProduct.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfraEstructureModel(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();


app.AddMapEndpointsService();
app.Run();
