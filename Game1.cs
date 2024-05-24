using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_3_Animation
{
    public class Game1 : Game
    {
        Rectangle greyTribbleRect;
        Rectangle orangeTribbleRect;
        Rectangle brownTribbleRect;
        Rectangle creamTribbleRect;
        Vector2 tribbleGreySpeed; 
        Vector2 tribbleBrownSpeed;
        Vector2 tribbleCreamSpeed;
        Vector2 tribbleOrangeSpeed;



        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
            Texture2D tribbleOrangeTexture;
            Texture2D tribbleGreyTexture;
            Texture2D tribbleCreamTexture;
            Texture2D tribbleBrownTexture;

        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            


        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            greyTribbleRect = new Rectangle(300, 10, 100, 100);
            tribbleGreySpeed = new Vector2(2, 2);
            orangeTribbleRect = new Rectangle(0,0, 150,150);
            tribbleOrangeSpeed = new Vector2(3, 1);
            brownTribbleRect = new Rectangle(300,300, 75,75);
            tribbleBrownSpeed = new Vector2(6, 0);
            creamTribbleRect = new Rectangle(200, 0, 50, 50);
            tribbleCreamSpeed = new Vector2(0,8);

            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here
            _spriteBatch.Begin();
            greyTribbleRect.X += (int)tribbleGreySpeed.X;
            greyTribbleRect.Y += (int)tribbleGreySpeed.Y;
            if (greyTribbleRect.Right > _graphics.PreferredBackBufferWidth || greyTribbleRect.Left < 0)
                tribbleGreySpeed.X *= -1; 

            if (greyTribbleRect.Bottom > _graphics.PreferredBackBufferHeight || greyTribbleRect.Top  < 0 )
                tribbleGreySpeed.Y *= -1;

            orangeTribbleRect.X += (int)tribbleOrangeSpeed.X;
            orangeTribbleRect.Y += (int)tribbleOrangeSpeed.Y;
            if (orangeTribbleRect.Right > _graphics.PreferredBackBufferWidth || orangeTribbleRect.Left < 0)
                tribbleOrangeSpeed.X *= -1;

            if (orangeTribbleRect.Bottom > _graphics.PreferredBackBufferHeight || orangeTribbleRect.Top < 0)
                tribbleOrangeSpeed.Y *= -1;
            //
            brownTribbleRect.X += (int)tribbleBrownSpeed.X;
            brownTribbleRect.Y += (int)tribbleBrownSpeed.Y;
            if (brownTribbleRect.Right > _graphics.PreferredBackBufferWidth || brownTribbleRect.Left < 0)
                tribbleBrownSpeed.X *= -1;

            if (brownTribbleRect.Bottom > _graphics.PreferredBackBufferHeight || brownTribbleRect.Top < 0)
                tribbleBrownSpeed.Y *= -1;

            creamTribbleRect.X += (int)tribbleCreamSpeed.X;
           creamTribbleRect.Y += (int)tribbleCreamSpeed.Y;
            if (creamTribbleRect.Right > _graphics.PreferredBackBufferWidth || creamTribbleRect.Left < 0)
                tribbleCreamSpeed.X *= -1;

            if (creamTribbleRect.Bottom > _graphics.PreferredBackBufferHeight || creamTribbleRect.Top < 0)
                tribbleCreamSpeed.Y *= -1;


            _spriteBatch.End();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

           // _spriteBatch.Draw(tribbleBrownTexture, new Vector2(0, 0), Color.White);
           // _spriteBatch.Draw(tribbleCreamTexture, new Vector2(0, 0), Color.White);
          //  _spriteBatch.Draw(tribbleOrangeTexture, new Vector2(0, 0), Color.White);
            //_spriteBatch.Draw(tribbleGreyTexture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(tribbleGreyTexture, greyTribbleRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture,orangeTribbleRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, brownTribbleRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, creamTribbleRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
