using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class LeftCommand : ICommand
    {
        public void Execute(Pacman pacman)
        {
            pacman.Direction = new Vector2D(1, 0);
            pacman.Loop();
        }
    }
}
