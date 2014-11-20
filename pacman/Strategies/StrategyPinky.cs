using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Pinky is a Pink Ghost that is Mischievous, Persistent, and Tricky.
    /// </summary>
    class StrategyPinky : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            Field field = gameObject.Field;
            Pacman pacman = field.Pacman;
            Enemy blinky = field.GetBlinky();
            Vector2D target;

            if (blinky == null || gameObject.Location.Distance(pacman.Location) <= 2)
            {
                target = pacman.Location;
            }
            else
            {
                Vector2D towards = pacman.GetDestination(2);
                Vector2D distanceVector = gameObject.Location.GetDistanceVector(towards);
                int difference = (int)gameObject.Location.Distance(towards);
                int i = 0;
                while (i < difference && field.Contains(towards))
                {
                    towards.Add(distanceVector);
                    i++;
                }
                target = towards;
            }

            gameObject.Direction = MazeSolver.SolveForDirection(field, gameObject.Location, target);
            gameObject.Speed = Enemy.DefaultSpeed;
        }
    }
}
