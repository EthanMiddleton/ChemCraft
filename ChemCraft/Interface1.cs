using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChemCraft
{
    public abstract class Card
    {
        // Image to display
        Texture2D texture;

        // Element/compound symbol
        string symbol;

        // Description to be shown when hovered over
        string description;

        // State of card
        int state;

        // Position variables (not player controlled)
        int x, y;

        // Cost of the card
        int cost;

        // Atomic number
        int id;


        // Properties
        // State
        int State
        {
            get{ return state;  }
            set{ state = value; }
        }
        // x location
        int X {
            get { return x;  }
            set { x = value; }
        }
        // Y location
        int Y {
            get { return y;  }
            set { y = value; }
        }
    }
}
