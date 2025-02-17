using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GameMonogame
{
    internal class Pipe : GameEntity
    {
        private Texture2D pipeTexture;
        private Vector2 Position; 

        public Pipe(GameManager game, Vector2 initialPosition) : base(game, initialPosition)
        {
            gameManager = game;
            Position = initialPosition;
            pipeTexture = gameManager.Content.Load<Texture2D>("SandyWall"); 

        }

        public void Update(float deltaTime)
        {

        }

        public void DrawPipe() 
        {
            gameManager.SpriteBatch.Draw(pipeTexture, new Rectangle((int)Position.X, (int)Position.Y, pipeTexture.Width, pipeTexture.Height), Color.White);
        }


    }
}
