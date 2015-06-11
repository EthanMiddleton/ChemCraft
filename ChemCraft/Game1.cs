using System;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading.Tasks;

namespace ChemCraft
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Field Class where all actions are performed
        Field field;
        string say;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            field = new Field();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            field.cycle();
            ConsoleDraw();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        private void ConsoleDraw()
        {

            Console.SetWindowSize(1, 1);
            // Show health and energy
            say = "Health: " + field.player[0].Health + "         Energy: " + field.player[0].Energy;
            Console.WriteLine(say);

            // Show hand
            say = field.player[0].Hand[0].elementSymbol;
            for (int i = 1; i < field.player[0].Hand.Count; i++)
            {
                say += ", " + field.player[0].Hand[i].elementSymbol;
            }
            Console.WriteLine(say);

            // Show Compounds
            say = field.player[0].Compounds[0].GetName;
            for (int i = 1; i < field.player[0].Compounds.Count; i++)
            {
                say += ", " + field.player[0].Compounds[i].GetName;
            }
            Console.WriteLine(say);

            // Show defenses
            say = field.player[0].Defense[0].GetName;
            for (int i = 1; i < field.player[0].Defense.Count; i++)
            {
                say += ", " + field.player[0].Defense[i].GetName;
            }
            Console.WriteLine(say);

            // Middle stuff
            Console.WriteLine("Player 1");
            Console.WriteLine("");
            Console.WriteLine("Player 2");

            // Show defenses
            say = field.player[1].Defense[0].GetName;
            for (int i = 1; i < field.player[1].Defense.Count; i++)
            {
                say += ", " + field.player[1].Defense[i].GetName;
            }
            Console.WriteLine(say);

            // Show Compounds
            say = field.player[1].Compounds[0].GetName;
            for (int i = 1; i < field.player[1].Compounds.Count; i++)
            {
                say += ", " + field.player[1].Compounds[i].GetName;
            }
            Console.WriteLine(say);

            // Show hand
            say = field.player[1].Hand[0].elementSymbol;
            for (int i = 1; i < field.player[1].Hand.Count; i++)
            {
                say += ", " + field.player[1].Hand[i].elementSymbol;
            }
            Debug.WriteLine(say);

            // Show health and energy
            say = "Health: " + field.player[1].Health + "         Energy: " + field.player[1].Energy;
            Console.WriteLine(say);

        }
    }
}
