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


        public void Draw()
        {
            gameManager.SpriteBatch.Draw(fish_texture, new Rectangle((int)Position.X, (int)Position.Y,
            fish_texture.Width, fish_texture.Height), null,
            Color.White, Rotation, new Vector2(fish_texture.Width * 0.5f,
            fish_texture.Height * 0.5f), SpriteEffects.None, 0.0f);
        }

    }
}
