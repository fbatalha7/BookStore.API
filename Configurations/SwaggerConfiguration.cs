namespace BookStore.API.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "BookStore API",
                    Version = "v1",
                    Description = "API for managing a bookstore",
                    Contact = new()
                    {
                        Name = "BookStore Support",
                        Email = "example@email.com"
                    }
                });
            });
        }

    }
}