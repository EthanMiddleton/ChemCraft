using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class N2O : Compound
    {

        public N2O() 
        {
            name = "Laughing Gas";
            state = 0;
            elementnum = 3;
            damage = 2;
            formula = "N₂O";
            type = Type.Undetermined;
            elements = new int[3] {7,7,8};
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
       override public void ability()
        {

        }

    }
}
