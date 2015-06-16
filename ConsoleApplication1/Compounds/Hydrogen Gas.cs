using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class H2 : Compound
    {

        public H2()
        {
            name = "Hydrogen Gas";
            state = 0;
            elementnum = 2;
            damage = 1;
            formula = "H₂";
            type = Type.Undetermined;
            elements = new int[2] { 1, 1};

        }

        /// <summary>
        ///the compounds ability
        /// </summary>
        override public void ability()
        {

        }

    }
}
