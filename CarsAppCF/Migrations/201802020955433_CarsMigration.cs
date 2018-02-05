namespace CarsAppCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        CarTypeId = c.Int(nullable: false),
                        Consumption = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.CarTypes", t => t.CarTypeId, cascadeDelete: true)
                .Index(t => t.CarTypeId);
            
            CreateTable(
                "dbo.CarTypes",
                c => new
                    {
                        CarTypeId = c.Int(nullable: false, identity: true),
                        CarTypeName = c.String(),
                    })
                .PrimaryKey(t => t.CarTypeId);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelId = c.Int(nullable: false, identity: true),
                        TravelName = c.String(),
                        DirectionId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                        TravelDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TravelId)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Directions", t => t.DirectionId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.DirectionId);
            
            CreateTable(
                "dbo.Directions",
                c => new
                    {
                        DirectionId = c.Int(nullable: false, identity: true),
                        DirectionName = c.String(),
                        DepartureId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                        Distance = c.Double(nullable: false),
                        Point_PointId = c.Int(),
                        Point_PointId1 = c.Int(),
                        Point_PointId2 = c.Int(),
                        Point1_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.DirectionId)
                .ForeignKey("dbo.Points", t => t.Point_PointId)
                .ForeignKey("dbo.Points", t => t.Point_PointId1)
                .ForeignKey("dbo.Points", t => t.Point_PointId2)
                .ForeignKey("dbo.Points", t => t.Point1_PointId)
                .Index(t => t.Point_PointId)
                .Index(t => t.Point_PointId1)
                .Index(t => t.Point_PointId2)
                .Index(t => t.Point1_PointId);
            
            CreateTable(
                "dbo.Points",
                c => new
                    {
                        PointId = c.Int(nullable: false, identity: true),
                        PointName = c.String(),
                    })
                .PrimaryKey(t => t.PointId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Travels", "DirectionId", "dbo.Directions");
            DropForeignKey("dbo.Directions", "Point1_PointId", "dbo.Points");
            DropForeignKey("dbo.Directions", "Point_PointId2", "dbo.Points");
            DropForeignKey("dbo.Directions", "Point_PointId1", "dbo.Points");
            DropForeignKey("dbo.Directions", "Point_PointId", "dbo.Points");
            DropForeignKey("dbo.Travels", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarTypeId", "dbo.CarTypes");
            DropIndex("dbo.Travels", new[] { "DirectionId" });
            DropIndex("dbo.Directions", new[] { "Point1_PointId" });
            DropIndex("dbo.Directions", new[] { "Point_PointId2" });
            DropIndex("dbo.Directions", new[] { "Point_PointId1" });
            DropIndex("dbo.Directions", new[] { "Point_PointId" });
            DropIndex("dbo.Travels", new[] { "CarId" });
            DropIndex("dbo.Cars", new[] { "CarTypeId" });
            DropTable("dbo.Points");
            DropTable("dbo.Directions");
            DropTable("dbo.Travels");
            DropTable("dbo.CarTypes");
            DropTable("dbo.Cars");
        }
    }
}
