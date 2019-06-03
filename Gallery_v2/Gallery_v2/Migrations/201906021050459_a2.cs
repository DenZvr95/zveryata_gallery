namespace Gallery_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpToPic",
                c => new
                    {
                        ExpId = c.Int(nullable: false),
                        IdPic = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExpId, t.IdPic })
                .ForeignKey("dbo.Expositions", t => t.ExpId, cascadeDelete: true)
                .ForeignKey("dbo.Pictures", t => t.IdPic, cascadeDelete: true)
                .Index(t => t.ExpId)
                .Index(t => t.IdPic);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpToPic", "IdPic", "dbo.Pictures");
            DropForeignKey("dbo.ExpToPic", "ExpId", "dbo.Expositions");
            DropIndex("dbo.ExpToPic", new[] { "IdPic" });
            DropIndex("dbo.ExpToPic", new[] { "ExpId" });
            DropTable("dbo.ExpToPic");
        }
    }
}
