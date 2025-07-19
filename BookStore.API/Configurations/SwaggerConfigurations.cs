namespace BookStore.API.Configurations
{
    public static class SwaggerConfigurations
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

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
                c.RoutePrefix = "api"; // Set the Swagger UI to be served at /api
            });
        }

    }
}