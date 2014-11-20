using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public interface IGameState
    {
        // Called after the game state has been placed in the game state manager
        void OnEntering();
    }
}
