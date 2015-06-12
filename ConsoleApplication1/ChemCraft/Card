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
        public Texture2D texture;

        // Element/compound symbol
        public string symbol;

        // Description to be shown when hovered over
        public string description;

        // State of card
        public int state;

        // Position variables (not player controlled)
        public int x, y;

        // Cost of the card
        public int cost;

        // Atomic number
        public int id;


        // Properties
        #region
        // State
        public int State
        {
            get{ return state;  }
            set{ state = value; }
        }
        // x location
        public int X {
            get { return x;  }
            set { x = value; }
        }
        // Y location
        public int Y {
            get { return y;  }
            set { y = value; }
        }
        #endregion
    }
}
