using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
     public abstract class Compound : Card
    {
        
        //number of elements
        public int elementnum;
        // whether the attacking is true
        public int state;
        //damage numbers
        public int damage;
        //name of compound
        public string name;
        //chemical formula
        public string formula;
        //type of element
        public enum type{Undetermined, Acid, Base};
        //list of elements ATOMIC number
        public int[] elements;
        // type of compound
        public type a;

        /// <summary>
        /// determines if the compound attacks that turn
        /// </summary>
        /// <returns>if compund attacks returns true else false</returns>
        public int attack
        {
            get { return damage; }

        }

        /// <summary>
        /// determines if the compund defends on that turn
        /// </summary>
        /// <returns>if the compund defends return true else false</returns>
        public int defend
        {
            get { return 0; }

        }

        /// <summary>
        /// gets the name of compund
        /// </summary>
        /// <returns>name</returns>
        public string GetName 
        {
            get { return name; }
        
        }

        /// <summary>
        /// gets chemical formula
        /// </summary>
        /// <returns>formula</returns>
        public string GetFormula 
        {
            get { return formula; }
        
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
        public abstract void ability();


    }
}
