using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class NaCl : Compound
    {

        public NaCl()
        {
            elementnum = 2;
            state = 0;
            damage = 3;
            name = "Table Salt";
            formula = "NaCl";
            a = type.Undetermined;
            elements = new int[2] { 11, 17 };
        }

        /// <summary>
        ///the compounds ability (makes opponent salty)
        /// </summary>
        override public void ability()
        {

        }
        
    }
}
