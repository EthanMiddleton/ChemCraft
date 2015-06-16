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

            if (keyState.IsKeyDown(Keys.D1) && uiPElement(0) != null)
                selectElement(0);
            else if (keyState.IsKeyDown(Keys.D2) && uiPElement(1) != null)
                selectElement(1);
            else if (keyState.IsKeyDown(Keys.D3) && uiPElement(2) != null)
                selectElement(2);
            else if (keyState.IsKeyDown(Keys.D4) && uiPElement(3) != null)
                selectElement(3);
            else if (keyState.IsKeyDown(Keys.D5) && uiPElement(4) != null)
                selectElement(4);
            else if (keyState.IsKeyDown(Keys.D6) && uiPElement(5) != null)
                selectElement(5);
            else if (keyState.IsKeyDown(Keys.NumPad0) && uiPCompound(0) != null)
                selectCompound(0);
            else if (keyState.IsKeyDown(Keys.NumPad1) && uiPCompound(1) != null)
                selectCompound(1);
            else if (keyState.IsKeyDown(Keys.NumPad2) && uiPCompound(2) != null)
                selectCompound(2);
            else if (keyState.IsKeyDown(Keys.NumPad3) && uiPCompound(3) != null)
                selectCompound(3);
            else if (keyState.IsKeyDown(Keys.NumPad4) && uiPCompound(4) != null)
                selectCompound(4);
            else if (keyState.IsKeyDown(Keys.NumPad5) && uiPCompound(5) != null)
                selectCompound(5);
            else if (keyState.IsKeyDown(Keys.NumPad6) && uiPCompound(6) != null)
                selectCompound(6);
            else if (keyState.IsKeyDown(Keys.NumPad7) && uiPCompound(7) != null)
                selectCompound(7);
            else if (keyState.IsKeyDown(Keys.NumPad8) && uiPCompound(8) != null)
                selectCompound(8);
            else if (keyState.IsKeyDown(Keys.NumPad9) && uiPCompound(9) != null)
                selectCompound(9);
        }

        //To display each Player's Elements on the GUI.
        public void displayPElements()
        {
         for(int e = 0; e < uiPELement.Count; e++)
         {
          
         }
        }

        //To display each Player's Compounds on the GUI.
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

        public void selectElement(int elementInHand)
        {
            uiPSElement.add(uiPElement(elementInHand));
        }

        public void selectCompound(int compoundInHand)
        {
            uiPSCompound.add(uiPCompound(compoundInHand));
        }
a
        public Rectangle GetBounds()
        {
           return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
        }
    }
}
