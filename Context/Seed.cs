
using Microsoft.EntityFrameworkCore;

namespace LOH_UserManagement.Context
{

    public static class Seed
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    Console.WriteLine("Applying Migrations....");
                    dbContext.Database.Migrate();
                    Console.WriteLine("Migrations Applied.");


                }
                SeedRoles(dbContext); // Call the method to seed roles
            }
        }

        private static void SeedRoles(AppDbContext dbContext)
        {

            dbContext.SaveChanges(); // Save changes to the database
        }
    }

}


