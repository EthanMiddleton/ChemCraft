using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public abstract class Card
    {
        // Image to display
        //public Texture2D texture;

        // Element/compound symbol
        public string symbol;

        // Description to be shown when hovered over
        public string description;

        // Position variables (not player controlled)
        public int x, y;

        // Properties
        #region
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
