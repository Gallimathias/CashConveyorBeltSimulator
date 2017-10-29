using CashConveyorBeltSimulator.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using engenious;
using CashConveyorBeltSimulator.Interfaces;

namespace CashConveyorBeltSimulator
{
    class Simulation
    {
        List<BaseItem> items;

        public Simulation()
        {
            items = new List<BaseItem>() {
                new Apple(0,0),
                new ConveyorBelt(0,0)
            };
        }

        internal List<KeyValuePair<string, Point>> GetItemPositions()
        {
            var tmpList = new List<KeyValuePair<string, Point>>();

            for (int i = 0; i < items.Count; i++)
                tmpList.Add(new KeyValuePair<string, Point>(
                    items[0].Name, items[0].Position));

            return tmpList;
        }

        internal void Update(GameTime gameTime)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] is IMoveable moveable)
                    MoveItem(moveable);

            }
        }

        private void MoveItem(IMoveable moveable)
        {
            var newPosition = moveable.AddToPosition(0, 1);
            
            //TODO Collision
        }
    }
}
