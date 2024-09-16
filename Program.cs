using Centric_Payment_API.DataBase;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Repository;
using Centric_Payment_API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();                                 

builder.Services.AddDbContext<PaymentEntities>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaymentEntities"));
});
builder.Services.AddDbContext<UsageEntities>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UsageEntities"));  
});
builder.Services.AddDbContext<StatementEntities>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("StatementEntities"));
});

builder.Services.AddScoped<IPaymentHistory, PaymentHistory>();
builder.Services.AddScoped<IModifyPaymentRepository, ModifyPaymentRepository>();
//builder.Services.AddScoped<PaymentEntities>();
builder.Services.AddScoped<IStatementHistory, StatementHistory>();
builder.Services.AddScoped<IModifyStatementRepository, ModifyStatementRepository>();
builder.Services.AddScoped<IUsageHistory, UsageHistory>();
builder.Services.AddScoped<IModifyUsgaeRepository, ModifyUsageRepository>();

builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

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
 