namespace P.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        IdContract = c.Int(nullable: false, identity: true),
                        IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdContract)
                .ForeignKey("dbo.Vehicles", t => t.IdVehicle)
                .Index(t => t.IdVehicle);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        IdVehicle = c.Int(nullable: false, identity: true),
                        Registration = c.String(nullable: false, maxLength: 15, storeType: "nvarchar"),
                        Brand = c.String(unicode: false),
                        SeatsNumber = c.Int(nullable: false),
                        ValueWhenNew = c.Double(nullable: false),
                        ValueWhenVenal = c.Double(nullable: false),
                        InitTraficDate = c.DateTime(nullable: false, precision: 0),
                        IdUser = c.Int(),
                        IdFiscalPower = c.Int(),
                    })
                .PrimaryKey(t => t.IdVehicle)
                .ForeignKey("dbo.FiscalPowers", t => t.IdFiscalPower)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdFiscalPower);
            
            CreateTable(
                "dbo.FiscalPowers",
                c => new
                    {
                        IdFiscalPower = c.Int(nullable: false, identity: true),
                        FPower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdFiscalPower);
            
            CreateTable(
                "dbo.Sinisters",
                c => new
                    {
                        IdSinister = c.Int(nullable: false, identity: true),
                        IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdSinister)
                .ForeignKey("dbo.Vehicles", t => t.IdVehicle)
                .Index(t => t.IdVehicle);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Surname = c.String(unicode: false),
                        User_IdUser = c.Int(),
                    })
                .PrimaryKey(t => t.IdUser)
                .ForeignKey("dbo.Users", t => t.User_IdUser)
                .Index(t => t.User_IdUser);
            
            CreateTable(
                "dbo.WreckReports",
                c => new
                    {
                        IdWReport = c.Int(nullable: false, identity: true),
                        WreckValue = c.Double(nullable: false),
                        Indemnity = c.Double(nullable: false),
                        IdVehicle = c.Int(),
                    })
                .PrimaryKey(t => t.IdWReport)
                .ForeignKey("dbo.Vehicles", t => t.IdVehicle)
                .Index(t => t.IdVehicle);
            
            CreateTable(
                "dbo.Warranties",
                c => new
                    {
                        IdWrr = c.Int(nullable: false, identity: true),
                        Warranty_IdWrr = c.Int(),
                    })
                .PrimaryKey(t => t.IdWrr)
                .ForeignKey("dbo.Warranties", t => t.Warranty_IdWrr)
                .Index(t => t.Warranty_IdWrr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warranties", "Warranty_IdWrr", "dbo.Warranties");
            DropForeignKey("dbo.WreckReports", "IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Users", "User_IdUser", "dbo.Users");
            DropForeignKey("dbo.Sinisters", "IdVehicle", "dbo.Vehicles");
            DropForeignKey("dbo.Vehicles", "IdFiscalPower", "dbo.FiscalPowers");
            DropForeignKey("dbo.Contracts", "IdVehicle", "dbo.Vehicles");
            DropIndex("dbo.Warranties", new[] { "Warranty_IdWrr" });
            DropIndex("dbo.WreckReports", new[] { "IdVehicle" });
            DropIndex("dbo.Users", new[] { "User_IdUser" });
            DropIndex("dbo.Sinisters", new[] { "IdVehicle" });
            DropIndex("dbo.Vehicles", new[] { "IdFiscalPower" });
            DropIndex("dbo.Vehicles", new[] { "IdUser" });
            DropIndex("dbo.Contracts", new[] { "IdVehicle" });
            DropTable("dbo.Warranties");
            DropTable("dbo.WreckReports");
            DropTable("dbo.Users");
            DropTable("dbo.Sinisters");
            DropTable("dbo.FiscalPowers");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Contracts");
        }
    }
}
