using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class C3H8O : Compound
    {

        public C3H8O(int[] myIDs) {
            name = "Rubbing Alcohol";
            elementnum = 3;
            damage = 2;
            formula = "C₃H₈O";
            type = Type.Undetermined;
            elements = new int[12] {6,6,6,1,1,1,1,1,1,1,1,8};
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
