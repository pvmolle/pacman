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
            gameObject.Direction = MazeSolver.SolveForDirection(gameObject.Field, gameObject.Location, gameObject.Field.Pacman.Location);
            gameObject.Speed = .2;
        }
    }
}
