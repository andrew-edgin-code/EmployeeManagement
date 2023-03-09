using EmployeeManagement.Data;
using EmployeeManagement.Repositories;
using EmployeeManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

#region Services
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<PositionService>();
builder.Services.AddScoped<EmployeeEmergencyContactService>();
builder.Services.AddScoped<EmployeePositionService>();
#endregion

#region Repository
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<PositionRepository>();
builder.Services.AddScoped<EmployeeEmergencyContactRepository>();
builder.Services.AddScoped<EmployeePositionRepository>();
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
