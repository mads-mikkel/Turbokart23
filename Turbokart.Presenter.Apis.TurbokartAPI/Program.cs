
using Microsoft.EntityFrameworkCore;

using Turbokart.Application.Interfaces;
using Turbokart.Application.UseCases;
using Turbokart.Infrastructure.Persistence.EfContexts;
using Turbokart.Infrastructure.Persistence.Interfaces;
using Turbokart.Infrastructure.Persistence.Repositories;

namespace Turbokart.Presenter.Apis.TurbokartAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<DbContext, TurbokartContext>();
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();
            builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IBookingUseCase, BookingUseCase>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
