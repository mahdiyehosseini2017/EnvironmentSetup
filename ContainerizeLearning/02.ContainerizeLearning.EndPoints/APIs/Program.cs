using ContainerizeLearning.Core.Domain;
using ContainerizeLearning.Infrastructure.Data.EfCore.SQL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPersonnelRepository, PersonnelRepository>();

builder.Services.AddDbContext<HRDbContext>
//(options => options.UseSqlServer("Initial Catalog=ContainerizeLearning; Data Source=localhost,1450;User ID=SA;Password= ir_ma_ho6655670;Persist Security Info=True"));
(options => options.UseSqlServer("Server =localhost,1433; Database=ContainerizeLearningDb ;User Id =sa;Password=<YourStrong@Passw0rd>; MultipleActiveResultSets=true"));
builder.Services.AddScoped<DbContext, HRDbContext>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
