﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ship_adventure
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D Ship;
        Texture2D Background;

        SpriteFont Font;

        Vector2 ShipPosition;

        string MY_TEXT;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
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
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            Ship = Content.Load<Texture2D>("blueships1");
            Background = Content.Load<Texture2D>("background");
            Font = Content.Load<SpriteFont>("defaultFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            Vector2 movement = Vector2.Zero;
            KeyboardState keystate = Keyboard.GetState();

            if (keystate.IsKeyDown(Keys.Right))
            {
                movement.X += 2;
            }

            if (keystate.IsKeyDown(Keys.Left))
            {
                movement.X -= 2;
            }

            if (keystate.IsKeyDown(Keys.Up))
            {
                movement.Y -= 2;
            }

            if (keystate.IsKeyDown(Keys.Down))
            {
                movement.Y += 2;
            }

            ShipPosition += movement;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            MY_TEXT = "Space Adventure";

            _spriteBatch.Begin();
            _spriteBatch.Draw(Background, Vector2.One, Color.White);
            _spriteBatch.Draw(Ship, ShipPosition, Color.White);
            _spriteBatch.DrawString(Font, MY_TEXT, Vector2.One, Color.Yellow);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
