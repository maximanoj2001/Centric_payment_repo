using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Centric_Payment_API.DataBase;
using Centric_Payment_API.Services;
using Centric_Payment_API.Interface;
using Centric_Payment_API.Repository;

namespace Centric_Payment_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<PaymentEntities>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("PaymentEntities")));

            services.AddScoped<IPaymentHistory, PaymentHistory>();
            services.AddScoped<IModifyPaymentRepository, ModifyPaymentRepository>();
            // Register other services and DbContexts as needed
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}