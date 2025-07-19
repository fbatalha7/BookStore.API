using BookStore.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookStore.API.Configurations
{
    public static class MigrationConfiguration
    {
        public static void AddMigrations(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            var databaseCreator = db.Database.GetService<IRelationalDatabaseCreator>() as RelationalDatabaseCreator;

            if (databaseCreator == null || !databaseCreator.Exists())
                databaseCreator.Create();

            db.Database.Migrate();

            if (db.Books.Any())
                return;

            db.Books.Add(new("Livro Inicial", "Autor", 2024, 99.90m));

            db.SaveChanges();
        }
    }
}
