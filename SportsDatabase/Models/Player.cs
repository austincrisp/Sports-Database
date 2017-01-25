using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public string Classification { get; set; }
        public int Weight { get; set; }
    }
}
