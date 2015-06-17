using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class F2 : Compound
    {

        public F2()
        {
            elementnum = 2;
            state = 0;
            damage = 1;
            name = "Fluorine Gas";
            formula = "F₂";
            type = Type.Undetermined;
            elements = new int[2] { 9, 9 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
