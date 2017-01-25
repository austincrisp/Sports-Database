using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Create a player to add to the 2016 Georgia Football roster! \n");
            Console.WriteLine("First let's get some information about the player.");

            Console.Write("What is the player's full name? ");
            string playerName = Console.ReadLine();

            Console.Write("What is the player's jersey number? ");
            int jerseyNumber = int.Parse(Console.ReadLine());

            Console.Write("What position does the player play? ");
            string position = Console.ReadLine();

            Console.WriteLine("\nGreat! Now let's get some stats! \n");

            if (position == "Quarterback")
            {
                Console.WriteLine($"How many completions did {playerName} throw? ");
                int completions = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many attempts did {playerName} make? ");
                int attempts = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many yards did {playerName} throw? ");
                int yards = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many touchdowns did {playerName} throw? ");
                int touchdowns = int.Parse(Console.ReadLine());
            }
            else if (position == "Wide Receiver" || position == "Receiver")
            {
                Console.WriteLine($"How many receptions did {playerName} have? ");
                int receptions = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many yards did {playerName} have? ");
                int yards = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many touchdowns did {playerName} have? ");
                int touchdowns = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"How many carries did {playerName} have? ");
                int carries = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many yards did {playerName} have? ");
                int yards = int.Parse(Console.ReadLine());

                Console.WriteLine($"How many touchdowns did {playerName} have? ");
                int touchdowns = int.Parse(Console.ReadLine());
            }

            using (var db = new PlayerStatContext())
            {
                Player player = new Player
                {
                    FullName = playerName,
                    Number = jerseyNumber,
                    Position = position
                };

                Stat stat = new Stat
                {
                    Completions = completions,
                };

                Team team = new Team
                {
                    Player = player,
                    Stat = stat,

                };
            }
            */
        }
    }
}
