using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class C8H9NO2 : Compound
    {

        public C8H9NO2()
        {
            elementnum = 20;
            state = 0;
            damage = 2;
            name = "Tylenol";
            formula = "C₈H₉NO₂";
            a = type.Base;
            elements = new int[20] { 6, 6, 6, 6, 6, 6, 6, 6, 1, 1, 1, 1, 1, 1, 1, 1, 1, 7, 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }
        
    }
}
