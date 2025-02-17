using GameMonogame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;


internal class Scene
{
    public List<GameObject> gameObjects = new List<GameObject>();


    public virtual void CreateScene() 
    {
        var newGameObject = AddGameObject();
        newGameObject.position = new System.Numerics.Vector2(100, 100);
        //newGameObject.AddComponent<Player>();
        //newGameObject.AddComponent<Sprite>();
    }

    public GameObject CreatePlayer() 
    {
        var newPlayer = AddGameObject();
        newPlayer.position = new Vector2(100, 100);
        //newPlayer.AddComponent<Player>();
        //var newSprite = newPlayer.AddComponent<Sprite>(new Sprite("Blue_Fish"));
        //var playerTexture = GameManager.Load<Texture2D>("Blue_Fish"); 
        //newSprite.texture = playerTexture;
        return newPlayer;


    }

    public GameObject AddGameObject() 
    {
        var newGameObject = new GameObject();   
        gameObjects.Add(newGameObject);
        return newGameObject;
    }

    public void Update(float deltaTime) 
    {
        for (int i = gameObjects.Count - 1; i >= 0; i--) 
        {
            gameObjects[i].Update(deltaTime);   
        }
    }

    public virtual void Draw(SpriteBatch _spriteBatch) 
    {
        for(int i = gameObjects.Count; i >= 0; i--) 
        {
            gameObjects[i].Draw(_spriteBatch);
        }
    }
}

