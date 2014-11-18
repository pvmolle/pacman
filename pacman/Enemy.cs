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
        private IStrategy attackingStrategy;
        private IStrategy fleeingStrategy; // The item that's under the enemy

        public bool IsFleeing { get; set; }

        public Enemy(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location)
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

            // Actual movement
            Move();
        }
    }
}
