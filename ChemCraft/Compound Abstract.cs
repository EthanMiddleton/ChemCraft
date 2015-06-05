using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chemcraft
{
     public abstract class Compounds
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
        public enum type{undetermined, Acid, Base};
        //arraylist of elements
        public int[] elements;
        // type of compound
        public type a;

        /// <summary>
        /// determines if the compound attacks that turn
        /// </summary>
        /// <returns>if compund attacks returns true else false</returns>
        abstract private int attack();

        /// <summary>
        /// determines if the compund defends on that turn
        /// </summary>
        /// <returns>if the compund defends return true else false</returns>
        abstract private int defend();

        /// <summary>
        /// gets the name of compund
        /// </summary>
        /// <returns>name</returns>
        abstract private string GetName();

        /// <summary>
        /// gets chemical formula
        /// </summary>
        /// <returns>formula</returns>
        abstract public string GetFormula();

        /// <summary>
        ///the compounds ability
        /// </summary>
        abstract public void ability();


    }
}
