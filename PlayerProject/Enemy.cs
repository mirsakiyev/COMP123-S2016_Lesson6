using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class Enemy : GameObject
    {
        private int _morale;

        public Enemy(string name)
            :base(name)
        {
            
        }

        public int Morale
        {
            get
            {
                return this._morale;
            }

            set
            {
                this._morale = value;
            }
        }

        public void Flee()
        {
            Console.WriteLine("{0} is fleeing", this.Name);
        }

        public void Seek()
        {
            Console.WriteLine("{0} is seeking", this.Name);
        }

        public void Patrol()
        {
            Console.WriteLine("{0} is patroling", this.Name);
        }
    }
}