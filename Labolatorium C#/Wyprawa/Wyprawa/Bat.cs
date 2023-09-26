using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {

        }
        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(1, 3) == 1)
                {
                    location = Move((Direction)random.Next(1, 4), game.Boundaries);
                }
                else
                    Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }
        }
    }
}
