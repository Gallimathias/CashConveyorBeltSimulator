using engenious;
using engenious.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashConveyorBeltSimulator.Components
{
    class LevelRenderer : DrawableGameComponent
    {
        private Texture2D tableElement;
        private Texture2D converyBelt;

        private SpriteBatch spriteBatch;

        public LevelRenderer(Game game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            //TODO Loading elments
            tableElement = Game.Content.Load<Texture2D>("wood_center");
            converyBelt = Game.Content.Load<Texture2D>("conveyor_belt");

            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(samplerState: SamplerState.LinearWrap);

            spriteBatch.Draw(converyBelt, new Rectangle(
                0,
                GraphicsDevice.Viewport.Height / 2 - 10,
                GraphicsDevice.Viewport.Width / 3 * 2,
                10),
                new Rectangle(0, 0, GraphicsDevice.Viewport.Width, 10),
                Color.White);

            spriteBatch.Draw(tableElement, new Rectangle(
                0,
                GraphicsDevice.Viewport.Height / 2,
                GraphicsDevice.Viewport.Width / 3 * 2,
                GraphicsDevice.Viewport.Height / 2),
                new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height),
                Color.White);

            spriteBatch.End();

        }

    }
}
