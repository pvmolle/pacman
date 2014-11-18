using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    delegate void Invoker();

    interface ICommand
    {
      // public Invoker Up, Down, Left, Right;

        void Execute(Pacman pacman);
    }
}
