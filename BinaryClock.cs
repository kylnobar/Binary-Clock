using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Binary_Clock
{
    public class BinaryClock : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D BackgroundTexture;
        private Texture2D pipTexture;
        private XYMapper Pipper;

        private int HourLeftPos = 46;
        private int HourRightPos = 96;
        private int MinuteLeftPos = 170;
        private int MinuteRightPos = 220;
        private int SecondLeftPos = 296;
        private int SecondRightPos = 346;

        public BinaryClock()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 416;
            _graphics.PreferredBackBufferHeight = 312;
            _graphics.ApplyChanges();

            Pipper = new XYMapper();
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            BackgroundTexture = Content.Load<Texture2D>("Sprites/background");
            pipTexture = Content.Load<Texture2D>("Sprites/pip");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(BackgroundTexture, new Vector2(0,0), Color.White);

            Pipper.DrawPips(Pipper.getRightDigit(DateTime.Now.Second), SecondRightPos, _spriteBatch, pipTexture);
            Pipper.DrawPips(Pipper.getLeftDigit(DateTime.Now.Second), SecondLeftPos, _spriteBatch, pipTexture);

            Pipper.DrawPips(Pipper.getRightDigit(DateTime.Now.Minute), MinuteRightPos, _spriteBatch, pipTexture);
            Pipper.DrawPips(Pipper.getLeftDigit(DateTime.Now.Minute), MinuteLeftPos, _spriteBatch, pipTexture);

            Pipper.DrawPips(Pipper.getRightDigit(DateTime.Now.Hour), HourRightPos, _spriteBatch, pipTexture);
            Pipper.DrawPips(Pipper.getLeftDigit(DateTime.Now.Hour), HourLeftPos, _spriteBatch, pipTexture);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}