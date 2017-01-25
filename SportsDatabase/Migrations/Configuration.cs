namespace SportsDatabase.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SportsDatabase.PlayerStatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SportsDatabase.PlayerStatContext context)
        {
            //  This method will be called after migrating to the latest version.


            var georgia = new Team
            {
                TeamName = "Georgia Bulldogs",
                Color = "Red and Black",
                Mascot = "Bulldog",
                City = "Athens",
                Stadium = "Sanford Stadium"
            };

            var jacob = new Player
            {
                FullName = "Jacob Eason",
                Number = 10,
                Position = "Quarterback",
                Classification = "Freshman",
                Weight = 235
            };

            var jacobStats = new Stat
            {
                Completions = 204,
                Attempts = 370,
                Yards = 2430,
                Touchdowns = 16,
                Player = jacob,
                Team = georgia
            };

            var greyson = new Player
            {
                FullName = "Greyson Lambert",
                Number = 11,
                Position = "Quarterback",
                Classification = "Senior",
                Weight = 234
            };

            var greysonStats = new Stat
            {
                Completions = 7,
                Attempts = 12,
                Yards = 56,
                Touchdowns = 0,
                Player = greyson,
                Team = georgia
            };

            var sony = new Player
            {
                FullName = "Sony Michel",
                Number = 1,
                Position = "Running Back",
                Classification = "Junior",
                Weight = 222
            };

            var sonyStats = new Stat
            {
                Carries = 152,
                Yards = 840,
                Touchdowns = 4,
                Player = sony,
                Team = georgia
            };

            var nick = new Player
            {
                FullName = "Nick Chubb",
                Number = 27,
                Position = "Running Back",
                Classification = "Junior",
                Weight = 228
            };

            var nickStats = new Stat
            {
                Carries = 224,
                Yards = 1130,
                Touchdowns = 8,
                Player = nick,
                Team = georgia
            };

            var brian = new Player
            {
                FullName = "Brian Herrien",
                Number = 35,
                Position = "Running Back",
                Classification = "Freshman",
                Weight = 210
            };

            var brianStats = new Stat
            {
                Carries = 63,
                Yards = 363,
                Touchdowns = 3,
                Player = brian,
                Team = georgia
            };

            var isaiah = new Player
            {
                FullName = "Isaiah McKenzie",
                Number = 16,
                Position = "Wide Receiver",
                Classification = "Junior",
                Weight = 175
            };

            var isaiahStats = new Stat
            {
                Receptions = 44,
                Yards = 633,
                Touchdowns = 7,
                Player = isaiah,
                Team = georgia
            };

            var terry = new Player
            {
                FullName = "Terry Godwin",
                Number = 5,
                Position = "Wide Receiver",
                Classification = "Sophomore",
                Weight = 185
            };

            var terryStats = new Stat
            {
                Receptions = 38,
                Yards = 397,
                Touchdowns = 0,
                Player = terry,
                Team = georgia
            };

            var isaac = new Player
            {
                FullName = "Isaac Nauta",
                Number = 18,
                Position = "Tight End",
                Classification = "Freshman",
                Weight = 246
            };

            var isaacStats = new Stat
            {
                Receptions = 29,
                Yards = 361,
                Touchdowns = 3,
                Player = isaac,
                Team = georgia
            };

            var riley = new Player
            {
                FullName = "Riley Ridley",
                Number = 8,
                Position = "Wide Receiver",
                Classification = "Freshman",
                Weight = 197
            };

            var rileyStats = new Stat
            {
                Receptions = 12,
                Yards = 238,
                Touchdowns = 2,
                Player = riley,
                Team = georgia
            };

            var javon = new Player
            {
                FullName = "Javon Wims",
                Number = 6,
                Position = "Wide Receiver",
                Classification = "Junior",
                Weight = 215
            };

            var javonStats = new Stat
            {
                Receptions = 17,
                Yards = 190,
                Touchdowns = 1,
                Player = javon,
                Team = georgia
            };

            context.Teams.AddOrUpdate(georgia);

            context.Players.AddOrUpdate(jacob);
            context.Players.AddOrUpdate(greyson);
            context.Players.AddOrUpdate(sony);
            context.Players.AddOrUpdate(nick);
            context.Players.AddOrUpdate(brian);
            context.Players.AddOrUpdate(isaiah);
            context.Players.AddOrUpdate(terry);
            context.Players.AddOrUpdate(isaac);
            context.Players.AddOrUpdate(riley);
            context.Players.AddOrUpdate(javon);

            context.Stats.AddOrUpdate(jacobStats);
            context.Stats.AddOrUpdate(greysonStats);
            context.Stats.AddOrUpdate(sonyStats);
            context.Stats.AddOrUpdate(nickStats);
            context.Stats.AddOrUpdate(brianStats);
            context.Stats.AddOrUpdate(isaiahStats);
            context.Stats.AddOrUpdate(terryStats);
            context.Stats.AddOrUpdate(isaacStats);
            context.Stats.AddOrUpdate(rileyStats);
            context.Stats.AddOrUpdate(javonStats);
        }
    }
}
