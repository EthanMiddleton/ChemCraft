using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class NaHCO3 : Compound
    {

        public NaHCO3(int[] myIDs) {
            name = "Baking Soda";
            state = 0;
            elementnum = 6;
            damage = 2;
            formula = " NaHCO₃";
            type = Type.Undetermined;
            elements = new int[6] {11,1,6,8,8,8};
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
