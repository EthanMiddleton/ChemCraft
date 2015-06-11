using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class NaClO : Compound
    {
       
        public NaClO(int[] myIDs) 
        {
            name = "Bleach";
            state = 0;
            elementnum = 3;
            damage = 2;
            formula = "NaClO";
            type = Type.Base;
            elements = new int[3] {11,17,8};
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
