using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public abstract class Enemy : AMoveable
    {
        private int position;
        private IStrategy attackingStrategy;
        private IStrategy fleeingStrategy;
        
        public bool IsFleeing { get; set; }

        public int Speed { get; set; }

        public Enemy(IGameObject[,] objects, IStrategy attackingStrategy, IStrategy fleeingStrategy) : base(objects)
        {
            this.attackingStrategy = attackingStrategy;
            this.fleeingStrategy = fleeingStrategy;
        }

        public override void Loop()
        {
            if (IsFleeing)
            {
                fleeingStrategy.Loop(this);
            }
            else
            {
                attackingStrategy.Loop(this);
            }
        }
    }
}
