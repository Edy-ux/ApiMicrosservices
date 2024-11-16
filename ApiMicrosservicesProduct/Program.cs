
using ApiMicrosservicesProduct.Extensions;
using ApiMicrosservicesProduct.Extensions.database;


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
