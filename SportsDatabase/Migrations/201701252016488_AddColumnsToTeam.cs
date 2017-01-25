namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsToTeam : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Teams", "Stat_Id", "dbo.Stats");
            DropIndex("dbo.Teams", new[] { "Player_Id" });
            DropIndex("dbo.Teams", new[] { "Stat_Id" });
            AddColumn("dbo.Players", "Team_Id", c => c.Int());
            AddColumn("dbo.Stats", "Player_Id", c => c.Int());
            AddColumn("dbo.Teams", "Color", c => c.String());
            AddColumn("dbo.Teams", "Mascot", c => c.String());
            AddColumn("dbo.Teams", "City", c => c.String());
            CreateIndex("dbo.Players", "Team_Id");
            CreateIndex("dbo.Stats", "Player_Id");
            AddForeignKey("dbo.Players", "Team_Id", "dbo.Teams", "Id");
            AddForeignKey("dbo.Stats", "Player_Id", "dbo.Players", "Id");
            DropColumn("dbo.Teams", "Player_Id");
            DropColumn("dbo.Teams", "Stat_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "Stat_Id", c => c.Int());
            AddColumn("dbo.Teams", "Player_Id", c => c.Int());
            DropForeignKey("dbo.Stats", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropIndex("dbo.Stats", new[] { "Player_Id" });
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropColumn("dbo.Teams", "City");
            DropColumn("dbo.Teams", "Mascot");
            DropColumn("dbo.Teams", "Color");
            DropColumn("dbo.Stats", "Player_Id");
            DropColumn("dbo.Players", "Team_Id");
            CreateIndex("dbo.Teams", "Stat_Id");
            CreateIndex("dbo.Teams", "Player_Id");
            AddForeignKey("dbo.Teams", "Stat_Id", "dbo.Stats", "Id");
            AddForeignKey("dbo.Teams", "Player_Id", "dbo.Players", "Id");
        }
    }
}
