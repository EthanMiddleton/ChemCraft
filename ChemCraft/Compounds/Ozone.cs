using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class O3 : Compound
    {

        public O3()
        {
            elementnum = 3;
            state = 0;
            damage = 2;
            name = "Ozone";
            formula = "O₃";
            type = Type.Undetermined;
            elements = new int[3] { 8, 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
