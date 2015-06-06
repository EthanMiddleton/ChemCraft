using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class H2O2 : Chemcraft.Compounds
    {

        public H2O2()
        {
            elementnum = 4;
            state = 0;
            damage = 4;
            name = "Hydrogen Peroxide";
            formula = "H₂O₂";
            a = type.Acid;
            elements = new int[4] { 1, 1, 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }
        
    }
}
