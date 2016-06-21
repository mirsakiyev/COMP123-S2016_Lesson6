using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerProject
{
    public abstract class GameObject
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS) +++++++++++++++++++++++++++++++++++++++++++++
        private int _attack;
        private int _defense;
        private int _lives;
        private string _name;
        private int _speed;
        private float _direction; // angle in degrees
        private Vector2 _position; // position in 2-dimensional space
        private Vector2 _facing;   // where the game object is looking at in 2-dimensional space

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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

        public Vector2 Position
        {
            get
            {
                return this._position;
            }

            set
            {
                this._position = value;
            }
        }

        public Vector2 Facing
        {
            get
            {
                return this._facing;
            }

            set
            {
                this._facing = value;
            }
        }

        public float Direction
        {
            get
            {
                return this._direction;
            }

            set
            {
                this._direction = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GameObject(string name)
        {
            this.Name = name;

            this._initialize();
        }


        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _initialize()
        {
            this.Attack = 0;
            this.Defense = 0;
            this.Lives = 0;
            this.Speed = 0;

            this.Position = new Vector2();
            this.Facing = new Vector2();
            this.Direction = this._calculateTargetAngle();
        }

        /**
         * <summary>
         * This utitlity method calculates the direction between two vectors
         * </summary>
         */
        private float _calculateTargetAngle()
        {
            float dx = this.Position.x - this.Facing.x;
            float dy = this.Position.y - this.Facing.y;
            dy = -dy;

            double radians = Math.Atan2(dy, dx);
            float targetAngle = Convert.ToSingle(radians * 180 / Math.PI); // angle in degrees
            targetAngle += 180f;

            return targetAngle;
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public override string ToString()
        {
            string returnString = "++++++++++++++++++++++++++++++++++\n";
            returnString += "Type: " + this.GetType().Name + "\n";
            returnString += "Attack: " + this.Attack + "\n";
            returnString += "Defense: " + this.Defense + "\n";
            returnString += "Name: " + this.Name + "\n";
            returnString += "Lives: " + this.Lives + "\n";
            returnString += "Speed: " + this.Speed + "\n";
            returnString += "Position.x: " + this.Position.x + "\n";
            returnString += "Position.y: " + this.Position.y + "\n";
            returnString += "Facing.x: " + this.Facing.x + "\n";
            returnString += "Facing.y: " + this.Facing.y + "\n";
            returnString += "Direction: " + this.Direction + "\n";
            returnString += "++++++++++++++++++++++++++++++++++\n";

            return returnString;
        }

        public void SetPosition(Vector2 newPosition)
        {
            this.Position = newPosition;
            this.Direction = this._calculateTargetAngle();
        }

        public void SetFacing(Vector2 newFacing)
        {
            this.Facing = newFacing;
            this.Direction = this._calculateTargetAngle();
        }

        public void MoveRight()
        {
            Console.WriteLine("{0} is moving right", this.Name);
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