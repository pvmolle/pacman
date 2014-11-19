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
        
        /// <summary>
        /// Detect when an enemy is at the same location as pacman.
        /// If so, game over
        /// </summary>
        public void DetectCollision()
        {
            AGameObject toRemove = null;
            foreach (AGameObject enemy in Field.Enemies)
            {
                
                if (enemy.Location.Equals(Location))
                {
                    if (!((Enemy)enemy).IsFleeing)
                    {
                        Debug.WriteLine("Game Over");
                        Field.IsGameOver = true;
                    }
                    else
                    {
                        Field.Score += enemy.Points;
                        toRemove = enemy;
                    }                 
                }
            }
            Field.Enemies.Remove((Enemy)toRemove);
        }

        public override void Loop()
        {
            // Do nothing when we don't move pacman
            if (Speed == 0) return;

            // Check the type of the next object
            int x = Location.X + Direction.X;
            int y = Location.Y + Direction.Y;
            AGameObject nextObjectCovered = Field.GameObjects[y, x];

            // Dot
            if (nextObjectCovered is Dot)
            {
                Field.GameObjects[y, x] = null;
                Field.Score += nextObjectCovered.Points;
                if (nextObjectCovered is Powerup)
                {
                    // Superpowers
                    foreach (AGameObject enemy in Field.Enemies)
                    {
                        ((Enemy)enemy).IsFleeing = true;
                    }
                }
            }

           

            Move();
            Speed = 0;
        }
    }
}
