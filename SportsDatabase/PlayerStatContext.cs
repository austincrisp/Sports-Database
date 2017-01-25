using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    public class PlayerStatContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
