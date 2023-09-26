using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 8)
        {

        }
        public override void Move(Random random)
        {
            //DAĆ JAKIŚ KOD
        }
    }
}
