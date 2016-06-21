using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public class ShootingEnemy : Enemy, IShootable, ITouchable
    {
        public ShootingEnemy(string name)
            : base(name)
        {

        }

        public void Shoot()
        {
            Console.WriteLine("{0} is shooting", this.Name);
        }

        public void Fight()
        {
            Console.WriteLine("{0} is fighting", this.Name);
        }
    }
}