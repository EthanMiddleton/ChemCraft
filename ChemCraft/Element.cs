using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    abstract class Element : Card
    {
        //transmute the element up or down a level on the periodic table
        abstract public Element transmute();

        //attack with the element, for a simple attack
        abstract public void attack();

        //defend with the element, for a simple shield
        abstract public void defense();

        //amount of electrons, ionic charge of the element, and how reactive the element is
        public int electrons, reactivity, state = 0;

        int X
        {
            get { return x; }
            set { x = value; }
        }
    }
}
