using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class CaCO3 : Compound
    {
         
        public CaCO3() 
        {
            name = "Marble";
            state = 0; 
            elementnum = 5;
            damage = 2;
            formula = "CaCO3";
            a = type.Undetermined;
            elements = new int[5] {20,6,8,8,8};
        }
        
        /// <summary>
        ///the compounds ability
        /// </summary>
       override public void ability()
        {

        }

    }
}
