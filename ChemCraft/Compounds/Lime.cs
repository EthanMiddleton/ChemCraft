using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class CaO : Compound
    {

        public CaO()
        {
            elementnum = 2;
            state = 0;
            damage = 2;
            name = "Calcium Oxide";
            formula = "CaO";
            type = Type.Undetermined;
            elements = new int[2] { 20, 8};
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
