using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;

namespace RecursionPractice
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            graphics.PreferredBackBufferWidth = 600;
            graphics.PreferredBackBufferHeight = 600;
            graphics.ApplyChanges();
            // TODO: use this.Content to load your game content here

        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            Carpet(GraphicsDevice.Viewport.Bounds, 2);

            // TODO: Add your drawing code here

            spriteBatch.End();
            base.Draw(gameTime);
        }

        void Carpet(Rectangle bounds,int numbofIterations)
        { 
            if(numbofIterations <= 0)
            {
                return;
            }
            int third = bounds.Width / 3;
            Rectangle middle = new Rectangle(bounds.X + third, bounds.Y + third,third,third);
            spriteBatch.FillRectangle(middle,Color.White);



            Rectangle Top = new Rectangle(bounds.X + third, bounds.Y + 0, third, third);
            Rectangle TL = new Rectangle(bounds.X + 0, bounds.Y + 0, third, third);
            Rectangle Bottom = new Rectangle(bounds.X + third, bounds.Y +2*third, third, third);
            Rectangle Right = new Rectangle(bounds.X + 2*third,bounds.Y + third,third,third);
            Rectangle Left = new Rectangle(bounds.X + 0,bounds.Y + third,third,third);
            Rectangle TR = new Rectangle(bounds.X+2*third,bounds.Y+0,third,third);
            Rectangle BL = new Rectangle(bounds.X + 0, bounds.Y + 2*third, third, third);
            Rectangle BR = new Rectangle(bounds.X + 2*third, bounds.Y + 2* third, third, third);
            numbofIterations--;
            Carpet(Top, numbofIterations);
            Carpet(TL, numbofIterations);
            Carpet(Bottom, numbofIterations);
            Carpet(Right, numbofIterations);
            Carpet(Left, numbofIterations);
            Carpet(TR, numbofIterations);
            Carpet(BL, numbofIterations);
            Carpet(BR, numbofIterations);
        }
    }
}
