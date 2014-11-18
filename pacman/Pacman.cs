using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class Pacman : AMoveable
    {
        protected override string Resource
        {
            get
            {
                string resource;
                if (Direction.X == 0)
                {
                    if (Direction.Y == -1)
                    {
                        resource = "../../../assets/pacman-up.png";
                    }
                    else
                    {
                        resource = "../../../assets/pacman-down.png";
                    }
                }
                else
                {
                    if (Direction.X == -1)
                    {
                        resource = "../../../assets/pacman-left.png";
                    }
                    else
                    {
                        resource = "../../../assets/pacman-right.png";
                    }
                }

                return resource;
            }
        }

        public Pacman(Field field, Vector2D location)
            : base(field, location)
        {
            
        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public override void Loop()
        {
            Move();
            Speed = 0;
            return;

            // collision detection
            // check if dot, powerup or enemy
            Vector2D nextLocation = new Vector2D(Location.X + Direction.X, Location.Y + Direction.Y);
            AGameObject gameObject = Field.GameObjects[nextLocation.Y, nextLocation.X];

            if (gameObject is Powerup)
            {
                // add points change game state
            }
            else if (gameObject is Dot)
            {
                // add points, remote dot 
            }
            else if (gameObject is Enemy)
            {
                // game over
            }

            Location = nextLocation; // move
        }
    }
}
