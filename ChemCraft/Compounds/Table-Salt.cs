using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class NaCl : Compound
    {

        public NaCl(int[] myIDs)
        {
            elementnum = 2;
            state = 0;
            damage = 3;
            name = "Table Salt";
            formula = "NaCl";
            type = Type.Undetermined;
            elements = new int[2] { 11, 17 };
            IDS = myIDs;
        }

        /// <summary>
        ///the compounds ability (makes opponent salty)
        /// </summary>
        override public void ability()
        {

        }
        
    }
}
