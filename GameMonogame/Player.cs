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
        private float maxFishRotation = 20f; 
        private GameTime gameTime;

        private float _deltaTime; 

        /// <summary>
        /// Creating the player. This needs a Game Manager and a vecto2 which will be the initial position
        /// </summary>
        /// <remarks>
        /// This game is so cool!!
        /// </remarks>
        /// <param name="_game"></param>
        /// <param name="initialPosition"></param>

        public Player(GameManager _game, Vector2 initialPosition) : base(_game, initialPosition)
        {
            position = initialPosition;
            gameManager = _game;
            fish_texture = gameManager.Content.Load<Texture2D>("Blue_Fish"); 
            
        }

        public void Update(GameTime gameTime) 
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                gameManager.Exit(); 
                

            _deltaTime = gameTime.ElapsedGameTime.Milliseconds * 0.01f;
            // TODO: Add your update logic here

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Space))
            {
                if (!isJumpPressed)
                {
                    gravity = flapForce;
                    isJumpPressed = true;
                }
            }
            else
            {
                isJumpPressed = false;
            }

            position.Y += gravity * _deltaTime;

            int heigthOfWindow = gameManager.Graphics.PreferredBackBufferHeight;
            int widthOfWindow = gameManager.Graphics.PreferredBackBufferWidth;

            if (gravity < maxGravity)
            {
                gravity = +_deltaTime * gravityDownSpeed;
            }

            if (gravity < 0)
            {
                if (fishRotation > -maxFishRotation) fishRotation -= _deltaTime * 1.0f; 
            } else
            {
                if (fishRotation < maxFishRotation) fishRotation += _deltaTime * 1.0f;     
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
