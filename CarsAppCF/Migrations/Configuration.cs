namespace CarsAppCF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CarsAppCF.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<CarsAppCF.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarsAppCF.Models.Model1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.CarType.AddOrUpdate(
            //  p => p.CarTypeName, DummyData.getCarTypes().ToArray());
            //context.SaveChanges();

            //context.Car.AddOrUpdate(c => new { c.CarName, c.Consumption}, DummyData.getCars(context).ToArray() );
            //context.SaveChanges();
        }
    }
}
