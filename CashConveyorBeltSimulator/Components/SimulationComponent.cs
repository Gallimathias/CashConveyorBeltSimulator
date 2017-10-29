using engenious;
using engenious.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Components
{
    class SimulationComponent : GameComponent
    {
        public readonly Simulation simulation;

        public SimulationComponent(Game game) : base(game)
        {
            simulation = new Simulation();
        }

        public override void Update(GameTime gameTime)
        {
            simulation.Update(gameTime);
        }
    }
}
