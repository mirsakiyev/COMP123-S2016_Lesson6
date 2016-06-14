using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class TouchingEnemy : Enemy, ITouchable
    {
        public TouchingEnemy(string name)
            :base(name)
        {
            
        }

        public void Fight()
        {
            Console.WriteLine("{0} is fighting", this.Name);
        }
    }
}