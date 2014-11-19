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

        public void HandleEnemyCollision(Enemy enemy)
        {
            if (enemy.IsFleeing)
            {
                Field.Enemies.Remove(enemy);
                Field.Score += enemy.Points;
            }
            else
            {
                Field.IsGameOver = true;
            }
        }

        public override void Loop()
        {
            Move();
            Speed = 0;

            AGameObject objectCovered = Field.Pacman.objectCovered;

            if (objectCovered == null)
            {
                return;
            }

            if (objectCovered is Enemy)
            {
                HandleEnemyCollision((Enemy)objectCovered);
            }
            else
            {
                Field.Score += objectCovered.Points;
                if (objectCovered is Powerup)
                {
                    foreach (AGameObject enemy in Field.Enemies)
                    {
                        ((Enemy)enemy).IsFleeing = true;
                    }
                }
            }
            Field.Pacman.objectCovered = null;
        }
    }
}
