using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class MazeSolver
    {
        public static Vector2D SolveForDirection(Field field, Vector2D from, Vector2D to)
        {
            Queue<Vector2D> queue  = new Queue<Vector2D>();

            AGameObject[,] gameObjects = field.GameObjects;
            int height = gameObjects.GetLength(0);
            int width = gameObjects.GetLength(1);
            int[,] weights = new int[height, width];

            queue.Enqueue(to);

            while (queue.Count > 0)
            {
                Vector2D fetched = queue.Dequeue();

                int x, y;
                foreach (Vector2D d in AMoveable.Directions)
                {
                    y = fetched.Y + d.Y;
                    x = fetched.X + d.X;
                    if (field.Contains(x, y))
                    {
                        AGameObject g = gameObjects[y, x];
                        Vector2D toAdd = new Vector2D(x, y);
                        if (g is Wall)
                        {
                            weights[y, x] = int.MaxValue;
                        }
                        else if (!(x == to.X && y == to.Y) && !queue.Contains(toAdd) && weights[y, x] == 0)
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
                int y = from.Y + d.Y;
                int x = from.X + d.X;
                if (field.Contains(x, y) && weights[y, x] < value && !(gameObjects[y, x] is Enemy || gameObjects[y, x] is Wall))
                {
                    value = weights[y, x];
                    direction = d;
                }
            }

            return direction;
        }
    }
}
