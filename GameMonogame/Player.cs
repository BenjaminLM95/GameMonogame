using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMonogame
{
    internal class Player : GameEntity
    {
        private Texture2D fish_texture;
        private Rectangle recCollider; 
        private Vector2 Position = new Vector2(100, 100);        
        private float gravity = 10f;
        private float maxGravity = 20f;
        private bool isJumpPressed = false;
        private float flapForce = 30f;
        private float gravityDownSpeed = 14f;
        private float fishRotation = 0f;

        private GameManager gameManager;

        public Player(GameManager _game, Vector2 initialPosition) : base(Game, initialPosition) 
        {
            gameManager = _game;
            fish_texture = gameManager.Content.Load<Texture2D>("Blue_Fish"); 
            
        }

        public void Update(float deltaTime) 
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float deltaTime = gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            // TODO: Add your update logic here

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Space))
            {
                if (!isJumpPressed)
                   position.Y -= flapForce;

                isJumpPressed = true;
            }
            else
            {
                isJumpPressed = false;
            }

            position.Y += gravity * deltaTime;

            int heigthOfWindow = gameManager.Graphics.PreferredBackBufferHeight;
            int widthOfWindow = gameManager.Graphics.PreferredBackBufferWidth;

            if (gravity < maxGravity)
            {
                gravity = +deltaTime * gravityDownSpeed;
            }

            if (gravity < 0)
            {
            }


        }

        public void Draw() 
        {
            gameManager.SpriteBatch.Draw(fish_texture, new Rectangle((int)Position.X, (int)Position.Y,
            fish_texture.Width, fish_texture.Height), null,
            Color.White, fishRotation, new Vector2(fish_texture.Width * 0.5f,
            fish_texture.Height * 0.5f), SpriteEffects.None, 0.0f);
        }

    }
}
