using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Zilang Liang
 * Date: July 11, 2017
 * Description: SuperHuman Class that extends the HUman Abstract class
 * Version: 0.2 - Added _initialize method
*/

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        //PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;
        //PUBLIC PROPERTIES

        //CONSTRUCTOR

        /// <summary>
        /// this is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }


        //PRIVATE METHODS
        /// <summary>
        /// This methods initializes, instantiates and ssigns value to class properties.
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>();//creates an empty list
        }

        //PUBLIC METHODS
    }
}