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
        private AGameObject objectCovered; // The item that's under the enemy
        
        public bool IsFleeing { get; set; }

        public int Speed { get; set; }

        public Enemy(AGameObject[,] objects, IStrategy attackingStrategy, IStrategy fleeingStrategy) : base(objects)
        {
            this.attackingStrategy = attackingStrategy;
            this.fleeingStrategy = fleeingStrategy;
            Points = 200;
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

            // actual movement
        }
    }
}
