using GameMonogame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

internal class Sprite : Component {

    public Texture2D texture;
    public Color color = Color.White;

    public Sprite(string initialTextureName) {
        //texture = GameManager.Load<Texture2D>("Blue_Fish"); 
            }

    /*
    public override void Draw(SpriteBatch _spriteBatch) 
    {
        base.Draw(_spriteBatch);
        _spriteBatch.Draw(texture, new Rectangle((int)gameObject.position.X, (int)gameObject.position.Y, texture.Width, texture.Height), color); 
    } */
        

 }

