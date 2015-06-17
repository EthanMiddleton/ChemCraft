using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class HCl : Compound
    {

        public HCl()
        {
            elementnum = 2;
            state = 0;
            damage = 5;
            name = "Muriatic Acid";
            formula = "HCl";
            type = Type.Acid;
            elements = new int[2] { 1, 17 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
        override public void ability()
        {

        }
        
    }
}
