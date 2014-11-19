using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // Do nothing when we don't move pacman
            if (Speed == 0)
            {
                return;
            }

            // Check the type of the next object
            int x = Location.X + Direction.X;
            int y = Location.Y + Direction.Y;
            AGameObject nextObjectCovered = Field.GameObjects[y, x];

            // Game over!
            if (nextObjectCovered is Enemy)
            {
                Debug.WriteLine("Game Over");
                Field.IsGameOver = true;
            }
            // Dot
            else if (!(nextObjectCovered is Wall))
            {
                // Superpowers
                if (nextObjectCovered is Powerup)
                {
                    Field.GameObjects[y, x] = null;
                    Field.Score += nextObjectCovered.Points;
                }
                else if (nextObjectCovered is Dot)
                {
                    Field.GameObjects[y, x] = null;
                    Field.Score += nextObjectCovered.Points;
                }
                Move();
                Speed = 0;
            }
        }
    }
}
