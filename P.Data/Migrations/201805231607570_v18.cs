namespace P.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        User_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idUser)
                .ForeignKey("dbo.Users", t => t.User_idUser)
                .Index(t => t.User_idUser);
            
            CreateTable(
                "dbo.Warranties",
                c => new
                    {
                        idWrr = c.Int(nullable: false, identity: true),
                        Warranty_idWrr = c.Int(),
                    })
                .PrimaryKey(t => t.idWrr)
                .ForeignKey("dbo.Warranties", t => t.Warranty_idWrr)
                .Index(t => t.Warranty_idWrr);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warranties", "Warranty_idWrr", "dbo.Warranties");
            DropForeignKey("dbo.Users", "User_idUser", "dbo.Users");
            DropIndex("dbo.Warranties", new[] { "Warranty_idWrr" });
            DropIndex("dbo.Users", new[] { "User_idUser" });
            DropTable("dbo.Warranties");
            DropTable("dbo.Users");
        }
    }
}
