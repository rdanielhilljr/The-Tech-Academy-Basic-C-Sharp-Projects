﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace twentyOne
{
   public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void listPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);

                
            }
        }

    }
}
