using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Name: Zilang Liang
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.4 - Added another a power to the SuperHuman object
 *              - Also displayed all the powers in the Powers List
*/
namespace COMP123_S2017_Lesson9B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superhuman = new SuperHuman("Super Dude");
            superhuman.AddPower("Spider Climbing", 50);
            superhuman.AddPower("Webcasting", 40);
            superhuman.DisplayPowers();
        }
    }
}
