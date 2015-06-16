using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public class CO2 : Compound
    {

        public CO2()
        {
            elementnum = 3;
            state = 0;
            damage = 4;
            name = "Carbon Dioxide";
            formula = "CO₂";
            type = Type.Undetermined;
            elements = new int[3] { 6, 8, 8 };
        }

        /// <summary>
        ///the compounds ability
        /// </summary> 
        override public void ability()
        {

        }

    }
}
