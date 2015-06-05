using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    abstract class Compound : Card
    {
        
        //number of elements
        public int elementnum;
        // whether the attacking is true
        public int state;
        //damage numbers
        public int damage;
        //name of compound
        public string name;
        //array of elements
        public string[] elements;
        //chemical formula
        public string formula;
        //acid or base
        public int acidorbase;
        public enum compType { Acid = 1, Base }
        public compType Type;



        /// <summary>
        /// determines if the compound attacks that turn
        /// </summary>
        /// <returns>if compund attacks returns true else false</returns>
        abstract public bool attack();

        /// <summary>
        /// determines if the compund defends on that turn
        /// </summary>
        /// <returns>if the compund defends return true else false</returns>
        abstract public bool defend();
       
        
    }
}
