using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class N2 : Compound
    {

        public N2()
        {
            elementnum = 2;
            state = 0;
            damage = 1;
            name = "Nitrogen Gas";
            formula = "N₂";
            type = Type.Undetermined;
            elements = new int[2] { 7, 7 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
