using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
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

        private Scene activeScene; 

        private Player player;

        private Pipe aPipe;

        private Pipe aPipe2;

        private Pipe aPipe3;

        private List<GameEntity> GameEntities = new List<GameEntity>();

        public Texture2D fish_texture;

        private SpriteFont myFont; 


        public GameManager()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            Instance = this; 
        }

        public static GameManager Instance;

        public T Load<T>(string textureName) 
        {
            return Content.Load<T>(textureName);
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //GameEntities.Add(new Player(this, new Vector2(100, 100)));
            player = new Player(this, new Vector2(100, 100));
            aPipe = new Pipe(this, new Vector2(400, GetRandomNumber()));
            aPipe2 = new Pipe(this, new Vector2(400, aPipe._position.Y - 70));
            aPipe3 = new Pipe(this, new Vector2(400, aPipe._position.Y - 140));
            myFont = Content.Load<SpriteFont>("MyFont");
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

        protected int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 230);
        }

        protected override void Update(GameTime gameTime)
        {
            player.Update(gameTime);
            Draw(gameTime);
            aPipe.Update(gameTime); 
            aPipe2.Update(gameTime);
            aPipe3.Update(gameTime);

            if(aPipe._position.X < -80) 
            {
                aPipe.Respawn();
                aPipe2._position = new Vector2(aPipe._position.X - 70, aPipe2._position.Y); 
                aPipe3._position = new Vector2(aPipe._position.X - 140, aPipe3._position.Y);
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.SkyBlue);

            _spriteBatch.Begin();

            //_spriteBatch.Draw(fish_texture, movementVector, Color.White);

            player.DrawPlayer();
            aPipe.DrawPipe();
            aPipe2.DrawPipe();
            aPipe3.DrawPipe();

            _spriteBatch.DrawString(myFont, player.Points.ToString(), new Vector2(50, 25), Color.Black); 

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
