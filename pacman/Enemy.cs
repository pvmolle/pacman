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
        private int position;
        private int speed;
        private bool isFleeing;

        public bool IsFleeing
        {
            get
            {
                return isFleeing;
            }
            set
            {
                // TODO
                isFleeing = value;
            }
        }

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
