using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Zilang Liang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.2 - Added a constructor
*/

namespace COMP123_S2017_Lesson9B
{
    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {
        //PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        //CONSTRUCTOR ----------------------
        /// <summary>
        /// this is the main constructor for the Power class.
        /// It takes two arguments - name(string) - rank(Int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}