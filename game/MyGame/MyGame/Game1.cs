using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public struct Input
    {
        public static MouseState mouse;
    }

    public struct Sprites
    {
        public static Texture2D paddle;
        public static Texture2D ball;
    }

    public struct Entities
    {
        public static PlayerPaddle player;
        public static EnemyPaddle enemy;
        public static Ball ball;
    }

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;


        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            Entities.player = new PlayerPaddle();
            Entities.enemy = new EnemyPaddle();
            Entities.ball = new Ball();

        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            Sprites.paddle = this.Content.Load<Texture2D>("paddle");
            Sprites.ball = Content.Load<Texture2D>("ball");
        }

        protected override void UnloadContent()
        {
            
        }

        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            Input.mouse = Mouse.GetState();

            base.Update(gameTime);
            Entities.player.Update(gameTime);
            Entities.enemy.Update(gameTime);
            Entities.ball.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            base.Draw(gameTime);
            Entities.player.Draw(spriteBatch);
            Entities.enemy.Draw(spriteBatch);
            Entities.ball.Draw(spriteBatch);
            spriteBatch.End();
            
        }
    }
}
