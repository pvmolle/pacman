using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Clyde is an Orange Ghost that is Ignorant and Goofy
    /// </summary>
    class StrategyClyde : IStrategy
    {
        private Random r;

        public StrategyClyde() {
            r = new Random();
        }

        public void Loop(AMoveable gameObject)
        {
            Field field = gameObject.Field;
            int height = field.GameObjects.GetLength(0);
            int width = field.GameObjects.GetLength(1);
            Vector2D randomLocation = new Vector2D(r.Next(height), r.Next(width));

            gameObject.Direction = MazeSolver.SolveForDirection(gameObject.Field, gameObject.Location, randomLocation);
            gameObject.Speed = Enemy.DefaultSpeed;
        }
    }
}
