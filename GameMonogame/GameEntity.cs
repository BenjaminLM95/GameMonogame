using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMonogame
{
    internal class GameEntity
    {
        protected Texture2D sprite;
        protected Rectangle collider;
        protected Vector2 position;
        protected float speed;
        protected GameManager gameManager;
        protected float Rotation;


        protected Vector2 movementDirection;

        public GameEntity(GameManager game, Vector2 initialPosition) 
        {
            position = initialPosition;
            gameManager = game;
            movementDirection = new Vector2(-80, 0); 
        }
        public void Draw()
        {
            gameManager.SpriteBatch.Draw(gameManager.fish_texture, new Rectangle((int)position.X, (int)position.Y,
            gameManager.fish_texture.Width, gameManager.fish_texture.Height), null,
            Color.White, Rotation, new Vector2(gameManager.fish_texture.Width * 0.5f,
            gameManager.fish_texture.Height * 0.5f), SpriteEffects.None, 0.0f);
        }

    }
}
