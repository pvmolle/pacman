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
            Pacman pacman = field.Pacman;
            Enemy blinky = field.GetBlinky();
            Vector2D target;

            if (blinky == null || gameObject.Location.Distance(pacman.Location) <= 4)
            {
                target = pacman.Location;
            }
            else
            {
                target = pacman.GetDestination(4);
            }

            gameObject.Direction = MazeSolver.SolveForDirection(field, gameObject.Location, target);
            gameObject.Speed = Enemy.DefaultSpeed;
        }
    }
}
