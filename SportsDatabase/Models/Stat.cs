using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    public class Stat
    {
        public int Id { get; set; }
        public int Completions { get; set; }
        public int Attempts { get; set; }
        public int Carries { get; set; }
        public int Receptions { get; set; }
        public int Yards { get; set; }
        public int Touchdowns { get; set; }
        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
