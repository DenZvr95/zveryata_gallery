namespace Gallery_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Born = c.DateTime(nullable: false, storeType: "date"),
                        Died = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Expositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        BeginData = c.DateTime(nullable: false, storeType: "date"),
                        EndData = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        PicId = c.Int(nullable: false, identity: true),
                        InventoryNumber = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        AuthorId = c.Int(),
                        Year = c.DateTime(nullable: false, storeType: "date"),
                        GenreId = c.Int(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status_Status = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PicId)
                .ForeignKey("dbo.Authors", t => t.AuthorId)
                .ForeignKey("dbo.Genres", t => t.GenreId)
                .ForeignKey("dbo.Statuses", t => t.Status_Status)
                .Index(t => t.AuthorId)
                .Index(t => t.GenreId)
                .Index(t => t.Status_Status);
            
            CreateTable(
                "dbo.Statuses",
                c => new
                    {
                        Status = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Status);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Position = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Position);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Position_Position = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Positions", t => t.Position_Position)
                .Index(t => t.Position_Position);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Position_Position", "dbo.Positions");
            DropForeignKey("dbo.Pictures", "Status_Status", "dbo.Statuses");
            DropForeignKey("dbo.Pictures", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.Pictures", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Users", new[] { "Position_Position" });
            DropIndex("dbo.Pictures", new[] { "Status_Status" });
            DropIndex("dbo.Pictures", new[] { "GenreId" });
            DropIndex("dbo.Pictures", new[] { "AuthorId" });
            DropTable("dbo.Users");
            DropTable("dbo.Positions");
            DropTable("dbo.Statuses");
            DropTable("dbo.Pictures");
            DropTable("dbo.Genres");
            DropTable("dbo.Expositions");
            DropTable("dbo.Authors");
        }
    }
}
