using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Aslan Mirsakiyev
 * Date: June 17, 2016
 * StudentID: 300850326
 * Description: This Program tests the Player and Enemy Classes
 * Version: 0.01 - Initial Test version  - testing basic classes and methods
 */

namespace PlayerProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TouchingEnemy redEnemy = new TouchingEnemy("red");
            redEnemy.SetPosition(new Vector2().NorthEast(20));
            redEnemy.SetFacing(new Vector2().Zero());
            Console.WriteLine(redEnemy.ToString());

            Player greenPlayer = new PlayerProject.Player("green");
            greenPlayer.SetFacing(redEnemy.Position);
            Console.WriteLine(greenPlayer.ToString());

            float distance = new Vector2().Magnitude(greenPlayer.Position, redEnemy.Position);

            Console.WriteLine("Distance between Player and Enemy: " + distance);


            WaitForAnyKey();
        }

        /**
         * <summary>
         * Utility method to wait for a console key press from the user 
         * </summary>
         * 
         * @method WaitForAnyKey
         * @returns {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
