using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tutorial001
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        /// <summary>
        /// The texture is what we view on the screen
        /// </summary>
        private Texture2D _texture;

        /// <summary>
        /// The position is where our object is relative to the top-left corner
        /// </summary>
        private Vector2 _position;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Use the content manager to load our texture
            _texture = Content.Load<Texture2D>("Box");

            // (0, 0) is the top-left corner
            _position = new Vector2(0, 0);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Let's MonoGame know we're about to add some sprites to the batcher
            spriteBatch.Begin();

            // The most basic sprite we can add.
            spriteBatch.Draw(_texture, _position, Color.White);

            // Can only be called after 'Begin'. Once called, draws everything added to the batcher
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}