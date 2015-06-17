using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class CaOH : Compound
    {

        public CaOH()
        {
            elementnum = 3;
            state = 0;
            damage = 2;
            name = "Calcium Hydroxide";
            formula = "CaOH";
            type = Type.Undetermined;
            elements = new int[3] { 20, 8, 1 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
