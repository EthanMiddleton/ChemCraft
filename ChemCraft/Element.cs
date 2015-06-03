using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    abstract partial class Element : Card
    {
        //transmute the element up or down a level on the periodic table
        abstract Element transmute;

        //attack with the element, for a simple attack
        abstract void attack;

        //defend with the element, for a simple shield
        abstract void defense;

        //amount of electrons, ionic charge of the element, and how reactive the element is
        public int electrons, reactivity, state = 0;


    }
}
