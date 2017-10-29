using CashConveyorBeltSimulator.Interfaces;
using engenious;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Items
{
    class Apple : BaseItem, IMoveable
    {
        public Apple(int x, int y)
        {
            Position = new Point(x, y);
            Name = nameof(Apple);
        }

        public Point AddToPosition(int x, int y) => Position = new Point(Position.X + x, Position.Y + y);

    }
}
