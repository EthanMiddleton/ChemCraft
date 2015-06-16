using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class O2 : Compound
    {

        public O2()
        {
            elementnum = 2;
            state = 0;
            damage = 1;
            name = "Oxygen Gas";
            formula = "O₂";
            type = Type.Undetermined;
            elements = new int[2] { 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
