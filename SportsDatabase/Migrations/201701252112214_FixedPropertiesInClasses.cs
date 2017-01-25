namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedPropertiesInClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stats", "Team_Id", c => c.Int());
            CreateIndex("dbo.Stats", "Team_Id");
            AddForeignKey("dbo.Stats", "Team_Id", "dbo.Teams", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stats", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Stats", new[] { "Team_Id" });
            DropColumn("dbo.Stats", "Team_Id");
        }
    }
}
