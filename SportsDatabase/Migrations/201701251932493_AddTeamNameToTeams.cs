namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamNameToTeams : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "TeamName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "TeamName");
        }
    }
}
