using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class KOH : Compounds
    {

        public KOH()
        {
            elementnum = 3;
            state = 0;
            damage = 4;
            name = "Potassium Hydroxide";
            formula = "KOH";
            a = type.Base;
            elements = new int[3] { 19, 8, 1 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }
        
    }
}
