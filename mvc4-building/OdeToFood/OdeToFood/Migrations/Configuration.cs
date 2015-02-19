namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeFoodDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OdeToFood.Models.OdeFoodDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "R2", City = "C2", Country = "SL" },
                new Restaurant { Name = "R3", City = "C3", Country = "SL" },
                new Restaurant { Name = "R4", City = "C4", Country = "USA" },
                new Restaurant
                {
                    Name = "R5",
                    City = "C5",
                    Country = "SL",
                    Reviews = new List<RestaurantReview> {
                    new RestaurantReview { Rating = 5, Body = "Body5", ReviewerName = "Tom_" }
                }
                }
                );

            for (int x = 0; x < 1000; x++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant { Name = "R_" + x.ToString(), City = "C_" + x.ToString(), Country = "SL" });
            }

        }
    }
}
