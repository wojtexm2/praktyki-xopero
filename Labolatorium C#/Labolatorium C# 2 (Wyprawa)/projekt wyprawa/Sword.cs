using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekt_wyprawa
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location)
        {

        }
        public override string Name { get { return "Miecz"; } }

        public override void Attack(Direction direction, Random random)
        {
            Direction firstSwing = direction;
            Direction secondSwing = direction;
            switch (direction)
            {
                case Direction.Up:

                    firstSwing = Direction.Right;
                    secondSwing = Direction.Left;
                    break;
                case Direction.Left:
                    firstSwing = Direction.Up;
                    secondSwing = Direction.Down;
                    break;
                case Direction.Down:
                    firstSwing = Direction.Left;
                    secondSwing = Direction.Right;
                    break;
                case Direction.Right:
                    firstSwing = Direction.Down;
                    secondSwing = Direction.Up;
                    break;
            }
            if (!DamageEnemy(direction, 25, 3, random))
            {
                if (!DamageEnemy(firstSwing, 25, 3, random))
                {
                    DamageEnemy(secondSwing, 25, 3, random);

                }
            }
        }
    }
}
