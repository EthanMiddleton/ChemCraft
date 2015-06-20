using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class Cl2 : Compound
    {

        public Cl2()
        {
            elementnum = 2;
            state = 0;
            damage = 1;
            name = "Chlorine Gas";
            formula = "Cl₂";
            type = Type.Undetermined;
            elements = new int[2] { 17, 17 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
