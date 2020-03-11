using System;
using System.Collections.Generic;
using System.Text;

namespace twentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
             throw new NotImplementedException(); 
        }
        public override void listPlayers()
        {
            Console.WriteLine("21 Playeers:");
            base.listPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
