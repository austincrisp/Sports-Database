namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Temp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Number = c.Int(nullable: false),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Completions = c.Int(nullable: false),
                        Attempts = c.Int(nullable: false),
                        Carries = c.Int(nullable: false),
                        Receptions = c.Int(nullable: false),
                        Yards = c.Int(nullable: false),
                        Touchdowns = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Player_Id = c.Int(),
                        Stat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .ForeignKey("dbo.Stats", t => t.Stat_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.Stat_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Stat_Id", "dbo.Stats");
            DropForeignKey("dbo.Teams", "Player_Id", "dbo.Players");
            DropIndex("dbo.Teams", new[] { "Stat_Id" });
            DropIndex("dbo.Teams", new[] { "Player_Id" });
            DropTable("dbo.Teams");
            DropTable("dbo.Stats");
            DropTable("dbo.Players");
        }
    }
}
