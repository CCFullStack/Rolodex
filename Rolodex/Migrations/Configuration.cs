namespace Rolodex.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rolodex.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Rolodex.Models.DataContext";
        }

        protected override void Seed(Rolodex.Models.DataContext context)
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

            context.Contacts.AddOrUpdate(
                c => c.Name,
                new Contact {
                    Name = "Eric Siebeneich",
                    Phone = "1234567890",
                    Birthday = new DateTime(1990, 4, 4),
                    Address = new Address {
                        Street = "Somewhere",
                        City = "Houston",
                        State = "TX",
                        Zip = "77047"
                    }
                },
                new Contact {
                    Name = "Havoc",
                    Phone = "1234567890",
                    Birthday = new DateTime(2014, 7, 1),
                    Address = new Address {
                        Street = "Somewhere",
                        City = "Houston",
                        State = "TX",
                        Zip = "77047"
                    }
                }
            );
        }
    }
}
