using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chemcraft
{
    abstract class AbstractCompounds
    {
        
        //number of elements
        abstract private int elementnum;
        // whether the attacking is true
        abstract private int state;
        //damage numbers
        abstract private int damage;
        //name of compound
        abstract private string name;
        //array of elements
        abstract private string[] elements;
        //chemical formula
        abstract private string formula;
        //acid or base
        abstract private int acidorbase;


        /// <summary>
        /// determines if the compound attacks that turn
        /// </summary>
        /// <returns>if compund attacks returns true else false</returns>
        abstract private bool attack();

        /// <summary>
        /// determines if the compund defends on that turn
        /// </summary>
        /// <returns>if the compund defends return true else false</returns>
        abstract private bool defend();
       
        
    }
}
