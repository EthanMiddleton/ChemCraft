using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class KOH : Compound
    {

        public KOH(int[] myIDs)
        {
            elementnum = 3;
            state = 0;
            damage = 4;
            name = "Potassium Hydroxide";
            formula = "KOH";
            type = Type.Base;
            elements = new int[3] { 19, 8, 1 };
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
