using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ChemCraft
{
  partial class Interface
    {
        Vector2 position;
        Vector2 motion;
        MouseState mouseState;
        KeyboardState keyboardState;
        GamePadState gamepadState;
        Texture2D texture;
        // Interface Screen Boundary
        Rectangle scrnbound;
        // Card 2D-dimensions
        const int cardWidth = 474, cardHeight = 686; 
        public string description; 

        List<Element> uiPElement, uiPSElement;
        List<Compound> uiPCompound, uiPSCompound;

        public void Update()
        {
            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState(motion);
            gamepadState = GamePad.GetState(PlayerIndex.One);
            uiPElement = Player.Hand;
            uiPCompound = Player.Compounds;
        }

        public Interface(Texture2D texture, Rectangle scrnbound)
        {
            this.texture = texture;
            this.scrnbound = scrnbound;
            //SetInStartPosition();
        }

       /* public void SetInStartPosition()
        {
            position.X = (scrnBound.Width - texture.Width) / 2;
            position.Y = (scrnBound.Height - texture.Height) - 5;
        }*/


        public void Draw (SpriteBatch spriteBatch, Texture2D texture, ) 
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void checkMouseState()
        {
            mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed)
            {
             //Do something.
            }

            if (mouseState.RightButton == ButtonState.Pressed)
            {        
              //Do something.
            }
        }

        public void checkKeyState()
        {
            keyboardState = Keyboard.GetState();
            
            if(keyState.IsKeyDown(Keys.D1))
            {
             //Select the first element in the player's hand when they press the "1" key.
            }

            else if(keyState.IsKeyDown(Keys.D2))
            {   
             //Select the second element in the player's hand when they press the "2" key.
            }

            else if(keyState.IsKeyDown(Keys.D3))
            {     
             //Select the third element in the player's hand when they press the "3" key.
            }

            else if(keyState.IsKeyDown(Keys.D4))
            {
             //Select the fourth element in the player's hand when they press the "4" key.
            }

            else if(keyState.IsKeyDown(Keys.D5))
            {
             //Select the fifth element in the player's hand when they press the "5" key.
            }

            else if(keyState.IsKeyDown(Keys.D6))
            {
             //Select the sixth element in the player's hand when they press the "6" key.
            }
        }

        //To display each Player's Elements
        public void displayPElements()
        {
         for(int e = 0; e < uiPELement.Count; e++)
         {
         }
        }

        //To display each Player's Compounds
        public void displayPCompounds()
        {
         for(int c = 0; c < uiPCompound.Count; c++)
         {
         }
        }

        // width of card = 4.74, height of card = 7.00
        public void showCardDescription()
        {

        }

 
        // The primary function of this method is to combine all elements, and send them to be displayed in the compounds area.
        // If the combination wanted by the user is not available, it sends the most recent card selected on the field.
        public void compute()
        {

        }

        public void selectElement()
        {
         //Add whatever element is being selected to a list of selected elements.
        }

        public void selectCompound()
        {
         //Add whatever compound is being selected to a list of selected compounds.
        }

        public Rectangle GetBounds()
        {
            return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }
    }
}




