using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace twentyOne
{
   public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public abstract void Play();


        public virtual void listPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name); 
            }
        }

    }
}
