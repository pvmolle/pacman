using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Enemy : AMoveable
    {
        private IStrategy strategy;

        public Enemy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Loop()
        {
            strategy.Loop(this);
        }
    }
}
