using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location)
        {

        }
        public override string Name { get { return "Miecz"; } }
        public override void Attack(Direction direction, Random random)
        {
            Direction first = direction;
            Direction second = direction;
            switch (direction)
            {
                case Direction.Up:

                    first = Direction.Right;
                    second = Direction.Left;
                    break;
                case Direction.Left:
                    first = Direction.Up;
                    second = Direction.Down;
                    break;
                case Direction.Down:
                    first = Direction.Left;
                    second = Direction.Right;
                    break;
                case Direction.Right:
                    first = Direction.Down;
                    second = Direction.Up;
                    break;
            }
            if (!DamageEnemy(direction, 10, 3, random))
            {
                if (!DamageEnemy(first, 10, 3, random))
                {
                    DamageEnemy(second, 10, 3, random);
                }
            }
        }
    }
}
