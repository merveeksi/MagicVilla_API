using MagicVilla_VillaAPI;
using MagicVilla_VillaAPI.Repository.IRepository;
using MagicVilla_VillaAPI.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
});
builder.Services.AddScoped<IVillaRepository, VillaRepository>();
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddControllers(option => { 
    //option.ReturnHttpNotAcceptable = true; 
}).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
//Learn more about configuring Swagger/ OpenAPI at https://aka.ms/aspanetcore/swashbuckl
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//other services
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
