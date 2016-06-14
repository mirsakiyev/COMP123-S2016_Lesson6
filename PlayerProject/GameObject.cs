using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class GameObject
    {
        private int _attack;
        private int _defense;
        private int _lives;
        private string _name;
        private int _speed;

        public GameObject(string name)
        {
            this.Name = name;
        }

        public int Lives
        {
            get
            {
                return this._lives;
            }

            set
            {
                this._lives = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public int Speed
        {
            get
            {
                return this._speed;
            }

            set
            {
                this._speed = value;
            }
        }

        public int Attack
        {
            get
            {
                return this._attack;
            }

            set
            {
                this._attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return this._defense;
            }

            set
            {
                this._defense = value;
            }
        }

        public void MoveRight()
        {
            Console.WriteLine("{0} is moving right",this.Name);
        }

        public void MoveLeft()
        {
            Console.WriteLine("{0} is moving left", this.Name);
        }

        public void MoveForward()
        {
            Console.WriteLine("{0} is moving forward", this.Name);
        }

        public void MoveBack()
        {
            Console.WriteLine("{0} is moving back", this.Name);
        }

        public void TurnLeft()
        {
            Console.WriteLine("{0} is turning left", this.Name);
        }

        public void TurnRight()
        {
            Console.WriteLine("{0} is turning right", this.Name);
        }
    }
}