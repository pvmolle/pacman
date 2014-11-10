using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Enemy : AMoveable
    {
        private int position;
        protected IStrategy strategy;
        public int Speed { get; set; }

        public abstract bool IsFleeing;

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
