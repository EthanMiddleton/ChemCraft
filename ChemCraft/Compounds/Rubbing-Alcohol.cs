using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class C3H8O : Compound
    {

        public C3H8O() {
            name = "Rubbing Alcohol";
            elementnum = 3;
            damage = 2;
            formula = "C3H8O";
            a = type.Undetermined;
            elements = new int[12] {6,6,6,1,1,1,1,1,1,1,1,8};
        }

   

        /// <summary>
        ///the compounds ability
        /// </summary>
       override public void ability()
        {

        }
        
    }
}
