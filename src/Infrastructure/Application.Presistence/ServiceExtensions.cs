using Application.Presistence.Context;
using Application.Presistence.Repository;
using Application.Presistence.Repository.TestTakersRepository;
using Application.Repository;
using Application.Repository.TestTakersRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Application.Presistence
{
    public static class ServiceExtensions
    {
        public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("PlacementTestContext");
            services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(connection));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITestTakerRepository, TestTakerRepository>();
        }
    }
}
