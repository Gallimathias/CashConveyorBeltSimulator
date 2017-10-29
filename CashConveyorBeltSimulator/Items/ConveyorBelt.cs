using CashConveyorBeltSimulator.Interfaces;
using engenious;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Items
{
    class ConveyorBelt : BaseItem, INonVisible
    {
        public ConveyorBelt(int x, int y)
        {
            Name = nameof(ConveyorBelt);
            Position = new Point(x, y);
        }
    }
}
