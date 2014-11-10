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

        public Vector Direction { get; set; }

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
