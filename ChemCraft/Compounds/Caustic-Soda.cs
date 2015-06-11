using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class NaOH : Compound
    {

        public NaOH(int[] myIDs)
        {
            elementnum = 3;
            state = 0;
            damage = 4;
            name = "Casutic Soda";
            formula = "NaOH";
            type = Type.Undetermined;
            elements = new int[3] { 11, 8, 1 };
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
