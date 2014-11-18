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
        public void Loop(AMoveable gameObject)
        {
            Field gameField = gameObject.Field;
            AGameObject[,] gameObjects = gameField.GameObjects;
            int height = gameObjects.GetLength(0);
            int width = gameObjects.GetLength(1);
            int max = Math.Max(height, width);
            int[,] field = new int[height, width];
            SetValue(gameField, field, gameField.Pacman.Location.Y, gameField.Pacman.Location.X, 0, max);
            Vector2D direction = new Vector2D(0, 0);
            int y, x;
            int value = max;
            foreach (Vector2D d in AMoveable.Directions)
            {
                y = gameObject.Location.Y + d.Y;
                x = gameObject.Location.X + d.X;
                if (gameField.Contains(x, y) && field[y, x] < value)
                {
                    value = field[y, x];
                    direction = d;
                }
            }
            gameObject.Direction = direction;
            gameObject.Speed = 1;
        }

        private void SetValue(Field gameField, int[,] field, int y, int x, int value, int max)
        {
            if (!gameField.Contains(x, y))
            {
                return;
            }

            AGameObject g = gameField.GameObjects[y, x];

            if (g is Pacman)
            {
                field[y, x] = 0;
            }
            else if (g is Enemy || g is Wall)
            {
                field[y, x] = max;
            }
            else if (field[y, x] == 0 && field[y, x] > value)
            {
                field[y, x] = value;
            }

            SetValue(gameField, field, y - 1, x, value + 1, max);
            SetValue(gameField, field, y + 1, x, value + 1, max);
            SetValue(gameField, field, y, x - 1, value + 1, max);
            SetValue(gameField, field, y, x + 1, value + 1, max);
        }
    }
}
