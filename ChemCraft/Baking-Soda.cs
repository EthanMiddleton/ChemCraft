using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    class NaHCO3 : Compound
    {

        public NaHCO3() {
            name = "Baking Soda";
            state = 0;
            elementnum = 6;
            damage = 2;
            formula = " NaHCO3";
            a = type.Undetermined;
            elements = new int[6] {11,1,6,8,8,8};

        }

        abstract public void ability() { 
        
        }
        
    }
}
