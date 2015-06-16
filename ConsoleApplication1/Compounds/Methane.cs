using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class CH4 : Compound
    {

        public CH4()
        {
            elementnum = 5;
            state = 0;
            damage = 5;
            name = "Carbon Tetrahydride";
            formula = "CH₄";
            type = Type.Undetermined;
            elements = new int[5] { 6, 1, 1, 1, 1 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
