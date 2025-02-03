using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace GameMonogame
{
    public class GameManager : Game
    {
        private GraphicsDeviceManager _graphics;

        public GraphicsDeviceManager Graphics { get { return _graphics;  } }      

        private SpriteBatch _spriteBatch;

        public SpriteBatch SpriteBatch { get { return _spriteBatch; } }

        private Player player; 

        private List<GameEntity> GameEntities = new List<GameEntity>(); 


        public GameManager()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            GameEntities.Add(new Player(this, new Vector2(100, 100))); 
            base.Initialize();

        }

        public void CreatePipe(Vector2 pipePosition) 
        {
            var newPipe = new Pipe(new Pipe); 
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            fish_texture = Content.Load<Texture2D>("Blue_Fish");  //Blue Fish
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);

            _spriteBatch.Begin();

            //_spriteBatch.Draw(fish_texture, movementVector, Color.White);

            
            _spriteBatch.Draw(fish_texture, new Rectangle((int)movementVector.X, (int)movementVector.Y, 
            fish_texture.Width, fish_texture.Height), null, 
            Color.White, fishRotation, new Vector2(fish_texture.Width * 0.5f, 
            fish_texture.Height * 0.5f), SpriteEffects.None, 0.0f);
            

            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        public static float DegreesToRadians(float angle) 
        {

            return angle; 
        }
    }
}
