using System;

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

        public Vector2D GetDestination(int placesAhead)
        {
            Vector2D destination = new Vector2D(this.Location);
            int i = 0;
            while (i < placesAhead && this.Field.Contains(destination.X, destination.Y))
            {
                destination.Add(this.Direction);
                i++;
            }
            return destination;
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