using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author : Aslan Mirsakiyev
 * Date : June 17, 2016
 * StudentID: 300850326
 * Description : This program teste the Player and Enemy classes
*/
namespace PlayerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player greenPlayer = new PlayerProject.Player("green");
            greenPlayer.MoveForward();

            TouchingEnemy redEnemy = new TouchingEnemy("red");
            redEnemy.MoveForward();
            WaitForAnyKey();
        }

        /**
        * <summary>
        * Utility method to wait for a console key press form user
        * </summary>
        * 
        * @method WaitForAnyKey
        * @returns {void}
        */
        public static void WaitForAnyKey()
        {
            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
