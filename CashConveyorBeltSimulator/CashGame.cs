using CashConveyorBeltSimulator.Components;
using engenious;
using engenious.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator
{
    class CashGame : Game
    {
        public readonly LevelRenderer LevelRenderer;
        public readonly SimulationComponent SimulationComponent;
        public readonly ItemLayerComponent itemLayerComponent;

        public CashGame()
        {
            GraphicsDevice.Viewport = new Viewport(0, 0, Window.ClientSize.Width, Window.ClientSize.Height);


            LevelRenderer = new LevelRenderer(this);
            SimulationComponent = new SimulationComponent(this);
            itemLayerComponent = new ItemLayerComponent(this);

            Components.Add(LevelRenderer);
            Components.Add(itemLayerComponent);
            Components.Add(SimulationComponent);

        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);
            LevelRenderer.Draw(gameTime);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
