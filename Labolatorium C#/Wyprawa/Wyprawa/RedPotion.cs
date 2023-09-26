using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class RedPotion : Weapon, IPotion
    {
        public bool Used { get { return Used; } }
        public override string Name { get { return "Czerwona mikstura"; } }
        public RedPotion(Game game, Point location) : base(game, location)
        {
        }
        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
            //TYŚTA TO ZRÓB!
        }
    }
}
