using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class H2O : Compound
    {

        public H2O(int[] myIDs)
        {
            name = "Water";
            state = 0;
            elementnum = 3;
            damage = 2;
            formula = "H₂O";
            type = Type.Undetermined;
            elements = new int[3] { 1, 1, 8 };
            IDS = myIDs;
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
       override public void ability()
        {

        }

    }
}
