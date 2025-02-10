using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Design;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace GameMonogame
{
    public class GameManager : Game
    {
        private GraphicsDeviceManager _graphics;

        /// <summary>
        /// this is the public graphic device manager which it has only a get. 
        /// </summary>
        public GraphicsDeviceManager Graphics { get { return _graphics;  } }      

        private SpriteBatch _spriteBatch;

        public SpriteBatch SpriteBatch { get { return _spriteBatch; } }

        private Player player; 

        private List<GameEntity> GameEntities = new List<GameEntity>();

        public Texture2D fish_texture; 


        public GameManager()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //GameEntities.Add(new Player(this, new Vector2(100, 100)));
            player = new Player(this, new Vector2(100, 100));

            base.Initialize();

        }

        public void CreatePipe(Vector2 pipePosition) 
        {
            var newPipe = new Pipe(this, pipePosition);   
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            fish_texture = Content.Load<Texture2D>("Blue_Fish");  //Blue Fish
            

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            player.Update(gameTime);
            Draw(gameTime); 
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Beige);

            _spriteBatch.Begin();

            //_spriteBatch.Draw(fish_texture, movementVector, Color.White);

            player.Draw(); 

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
