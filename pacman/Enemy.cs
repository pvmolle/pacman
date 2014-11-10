using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class Enemy : AMoveable
    {
        private int position;
        protected IStrategy strategy;
        public int Speed { get; set; }

        public abstract bool IsFleeing { get; set; }

        public Enemy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public override void Loop()
        {
            strategy.Loop(this);
        }
    }
}
