using ApiMicrosservicesProduct.Extensions;
using ApiMicrosservicesProduct.Mappings;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddInfraEstructureModel(builder.Configuration);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
