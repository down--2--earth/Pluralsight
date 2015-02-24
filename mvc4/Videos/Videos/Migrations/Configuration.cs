namespace Videos.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Videos.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Videos.Models.VideoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Videos.Models.VideoDb context)
        {
            context.Videos.AddOrUpdate(v => v.Title,
                new Video() { Title = "MVC4", Length=100 },
                new Video() { Title = "LINQ", Length = 200 });

            context.SaveChanges();
        }
    }
}
