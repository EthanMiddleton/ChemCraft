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
        private int elementnum;
        // whether the attacking is true
        private int state;
        //damage numbers
        private int damage;
        //name of compound
        private string name;
        //array of elements
        private enum elements { };
        //chemical formula
        private string formula;
        //type of element
        private enum type{};
        //arraylist of elements
        private ArrayList elements;

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
