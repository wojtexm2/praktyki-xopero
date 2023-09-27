using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekt_wyprawa
{
    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location)
        {

        }
        public override string Name { get { return "Bulawa"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(Direction.Up, 35, 6, random);
            DamageEnemy(Direction.Down, 35, 6, random);
            DamageEnemy(Direction.Left, 35, 6, random);
            DamageEnemy(Direction.Right, 35, 6, random);
        }
    }
}
