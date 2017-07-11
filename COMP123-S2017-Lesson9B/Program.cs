using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Name: Zilang Liang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.3 - Added a power to the SuperHuman object
*/
namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super Dude");
            superhuman.AddPower("Spider Climbing", 50);
        }
    }
}
