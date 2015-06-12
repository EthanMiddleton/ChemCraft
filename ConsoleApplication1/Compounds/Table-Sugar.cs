  using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class C12H22O11 : Compound
    {

        public C12H22O11() 
        {
            name = "Table Sugar";
            state = 0;
            elementnum = 45;
            damage = 2;
            formula = "C₁₂H₂₂O₁₁";
            type = Type.Undetermined;
            elements = new int[45] {6,6,6,6,6,6,6,6,6,6,6,6,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,8,8,8,8,8,8,8,8,8,8,8};
        }

       
        /// <summary>
        ///the compounds ability
        /// </summary>
       override public void ability()
        {

        }

    }
}
