using BookStore.API.Configurations;
using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API
{
    public class Startup(IConfiguration configuration)
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddEndpointsApiExplorer();

            services.AddSwaggerConfiguration();

            services.DependecyInjections();

            services.AddAutoMapperConfiguration();

            AddInfraConfiguration(services);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.AddMigrations();

            app.UseDeveloperExceptionPage();

            app.UseSwaggerConfiguration();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddInfraConfiguration(IServiceCollection services)
            => services.AddDbContext<AppDbContext>(options
                => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}