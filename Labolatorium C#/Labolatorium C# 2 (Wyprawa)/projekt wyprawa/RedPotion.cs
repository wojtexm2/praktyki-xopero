using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekt_wyprawa
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location)
               : base(game, location)
        {
            
        }
        public override string Name { get { return "Czerwona mikstura"; } }
        private bool used = false;
        public bool Used
        {
            get { return used; }
        }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
            used = true;
        }
    }
}
