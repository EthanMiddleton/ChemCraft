using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChemCraft
{
    public abstract class Compound
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
        public enum type { Undetermined, Acid, Base };
        //list of IDs
        public int[] IDs;
        //list of atomic number of elements
        public int[] elements;
        //type of the compound
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
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// gets chemical formula
        /// </summary>
        /// <returns>formula</returns>
        public string Formula
        {
            get { return formula; }
        }
        
        /// <summary>
        /// gets the IDs of the elements
        /// </summary>
        /// <returns>int array</returns>
        public int[] IDS
        {
            protected set { IDs = value; }
            get { return IDs; }
        }

        /// <summary>
        ///the compounds ability
        /// </summary>
        abstract public void ability();


    }
}
