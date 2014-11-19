using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class StrategyFleeing : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            gameObject.Direction = MazeSolver.SolveForDirection(gameObject.Field, gameObject.Location, gameObject.Field.Pacman.Location, false);
            gameObject.Speed = .2;
        }
    }
}
