using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Blinky is a Red Ghost that is Bad-Tempered and Bossy.
    /// Blinky receives a speed boost after a number of pac-pellets have been cleared. 
    /// </summary>
    class StrategyBlinky : IStrategy
    {
        Queue<Vector2D> queue;
        int[,] weights;

        public void Loop(AMoveable gameObject)
        {
            queue = new Queue<Vector2D>();

            Field gameField = gameObject.Field;
            AGameObject[,] gameObjects = gameField.GameObjects;
            int height = gameObjects.GetLength(0);
            int width = gameObjects.GetLength(1);
            weights = new int[height, width];

            queue.Enqueue(new Vector2D(gameField.Pacman.Location.X, gameField.Pacman.Location.Y));

            while (queue.Count > 0)
            {
                Vector2D fetched = queue.Dequeue();
                int x, y;
                foreach (Vector2D d in AMoveable.Directions)
                {
                    y = fetched.Y + d.Y;
                    x = fetched.X + d.X;
                    if (gameField.Contains(x, y))
                    {
                        AGameObject g = gameObjects[y, x];
                        Vector2D toAdd = new Vector2D(x, y);
                        if (g is Wall)
                        {
                            weights[y, x] = int.MaxValue;
                        }
                        else if (!(g is Pacman) && !queue.Contains(toAdd) && weights[y, x] == 0)
                        {
                            weights[y, x] = weights[fetched.Y, fetched.X] + 1;
                            queue.Enqueue(toAdd);
                        }
                    }
                }
            }

            int value = int.MaxValue;
            Vector2D direction = new Vector2D(0, 0);

            foreach (Vector2D d in AMoveable.Directions)
            {
                int y = gameObject.Location.Y + d.Y;
                int x = gameObject.Location.X + d.X;
                if (gameField.Contains(x, y) && weights[y, x] < value && !(gameObjects[y, x] is Enemy))
                {
                    value = weights[y, x];
                    direction = d;
                }
            }

            gameObject.Direction = direction;
            gameObject.Speed = 1;
        }
    }
}
