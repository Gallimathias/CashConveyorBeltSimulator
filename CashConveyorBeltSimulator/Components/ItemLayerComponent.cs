using engenious;
using engenious.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Components
{
    class ItemLayerComponent : DrawableGameComponent
    {
        private Dictionary<string, Texture2D> itemSprites;
        private SpriteBatch spriteBatch;

        public ItemLayerComponent(Game game) : base(game)
        {
            itemSprites = new Dictionary<string, Texture2D>();
        }

        protected override void LoadContent()
        {
            itemSprites.Add("Apple", Game.Content.Load<Texture2D>("apple"));
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        public override void Draw(GameTime gameTime)
        {
            var game = (CashGame)Game;

            spriteBatch.Begin();

            var itemPositions = game.SimulationComponent.simulation.GetItemPositions();

            for (int i = 0; i < itemPositions.Count; i++)
            {
                var item = itemPositions[i].Value;
                spriteBatch.Draw(itemSprites[itemPositions[i].Key], new Rectangle(item.X, item.Y, 116, 116),
                Color.White);
            }

            spriteBatch.End();
        }
    }
}
