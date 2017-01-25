namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsToPlayer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            AddColumn("dbo.Players", "Classification", c => c.String());
            AddColumn("dbo.Players", "Height", c => c.Int(nullable: false));
            AddColumn("dbo.Players", "Weight", c => c.Int(nullable: false));
            AddColumn("dbo.Teams", "Stadium", c => c.String());
            DropColumn("dbo.Players", "Team_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            DropColumn("dbo.Teams", "Stadium");
            DropColumn("dbo.Players", "Weight");
            DropColumn("dbo.Players", "Height");
            DropColumn("dbo.Players", "Classification");
            CreateIndex("dbo.Players", "Team_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
        }
    }
}
