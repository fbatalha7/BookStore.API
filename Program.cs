using BookStore.API.Configurations;

namespace BookStore.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddOpenApi();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerConfiguration();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
                app.MapOpenApi();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
                c.RoutePrefix = "api"; 
            });

            app.Run();
        }
    }
}
