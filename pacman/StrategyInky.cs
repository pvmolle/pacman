using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Inky is a Cyan Ghost that is Goofy, Shy, and Unpredictable.
    /// In Pac-Man, Inky likes to appear in front of Pac-Man's face.
    /// </summary>
    class StrategyInky : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            Field field = gameObject.Field;
            AMoveable pacman = field.Pacman;
            Vector2D destination = new Vector2D(pacman.Location);
            Vector2D direction = new Vector2D(pacman.Direction);
            int i = 0;
            while (gameObject.Location.Distance(destination) > 4 && i < 4 && field.Contains(destination.X, destination.Y))
            {
                destination.Add(direction);
                i++;
            }
            gameObject.Direction = MazeSolver.SolveForDirection(field, gameObject.Location, destination);
            gameObject.Speed = Enemy.DefaultSpeed;
        }
    }
}
