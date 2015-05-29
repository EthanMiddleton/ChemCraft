using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ChemCraft
{
    interface Card
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
        // Cost
        int Cost { get; set; }
        
        // State
        int State { get; set; }
        // x location
        new int X;
        // Y location
        int Y { get; set; }
        // Atomic Number
        int ID { get; set; }
    }
}
