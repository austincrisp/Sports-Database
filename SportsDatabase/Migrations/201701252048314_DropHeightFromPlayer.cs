namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropHeightFromPlayer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Players", "Height");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "Height", c => c.Int(nullable: false));
        }
    }
}
