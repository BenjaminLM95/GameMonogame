using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMonogame
{
    internal class Pipe : GameEntity
    {

        public Pipe(GameManager game, Vector2 initialPosition) : base(game, initialPosition)
        {
            gameManager = game;

        }

        public void Update(float deltaTime)
        {

        }


    }
}
