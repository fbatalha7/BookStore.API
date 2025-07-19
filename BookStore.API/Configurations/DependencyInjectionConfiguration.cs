using BookStore.Application.Interfaces;
using BookStore.Application.Services;
using BookStore.Infrastructure.Data.Interfaces;
using BookStore.Infrastructure.Data.Repositories;

namespace BookStore.API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void DependecyInjections(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IBookService, BookService>();


            //Repositories
            services.AddScoped<IBookRepository, BookRepository>();
        }

    }
}