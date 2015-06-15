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


        public void Draw (SpriteBatch spriteBatch, Texture2D texture) 
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void checkMouseState() //This method is run continuously and checks what state the mouse is in.
        {
            mouseState = Mouse.GetState();
            if (mouseState.LeftButton == ButtonState.Pressed) //LM Button pressed? Select the card under the cursor then.
            {
            }

            if (mouseState.RightButton == ButtonState.Pressed) //RM Button pressed? Display the description of the card under the cursor then?
            {           
            }
        }

        public void checkKeyState()
        {
            keyboardState = Keyboard.GetState();
            
            //HOTKEYS (Select any of the six elements in the player's hand).

            if(keyState.IsKeyDown(Keys.D1))
            {
            }

            else if(keyState.IsKeyDown(Keys.D2))
            {      
            }

            else if(keyState.IsKeyDown(Keys.D3))
            {     
            }

            else if(keyState.IsKeyDown(Keys.D4))
            {
            }

            else if(keyState.IsKeyDown(Keys.D5))
            {
            }

            else if(keyState.IsKeyDown(Keys.D6))
            {
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
        }

        public void selectCompound()
        {
        }

        public Rectangle GetBounds()
        {
            return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }
    }
}




