namespace Web_API.Migrations
{
    using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using Web_API.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<Web_API.Models.ContextAPI>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web_API.Models.ContextAPI context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var client = new Client
            {
                Name = "AMAN",
                Contact = "01770989547"

            };
            context.Clients.Add(client);
            context.Clients.AddRange(new List<Client>
            {
                new Client{Name="Ullah",Contact="01516500649"}
            });
            context.SaveChanges();

        }
    }
}
