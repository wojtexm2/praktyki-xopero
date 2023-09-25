﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                Math.Abs(location.Y - locationToCheck.Y) < distance) return true;
            else return false;
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top) newLocation.Y -= MoveInterval;
                    break;
                case direction.Down:
                    if (newLocation.Y - MoveInterval <= boundaries.Top) newLocation.Y += MoveInterval;
                    break;
            }
        }
    }
}
