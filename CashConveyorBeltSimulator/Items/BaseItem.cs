using engenious;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Items
{
    abstract class BaseItem
    {
        public Point Position { get; set; }
        public string Name { get; internal set; }

        public Rectangle CollisionBox { get; internal set; }
    }
}
