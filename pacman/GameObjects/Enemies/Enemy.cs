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
        public static double DefaultSpeed = .4;

        private IStrategy attackingStrategy;
        private IStrategy fleeingStrategy; // The item that's under the enemy
        protected int ticks;
        private bool isFleeing;

        public bool IsFleeing
        {
            get
            {
                return isFleeing;
            }
            set
            {
                if (value)
                {
                    ticks = 15 * 4;
                }
                isFleeing = value;
            }
        }

        protected override string Resource
        {
            get {
                if (ticks <= 12 && ticks % 3 == 0)
                {
                    return "../../../assets/ghost-blink.png";
                }
                return "../../../assets/ghost.png";
            }
        }

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
                ticks--;
                if (ticks <= 0)
                {
                    isFleeing = false;
                }
                fleeingStrategy.Loop(this);
            }
            else
            {
                attackingStrategy.Loop(this);
            }

            // Actual movement
            Move();

            if (objectCovered is Pacman)
            {
                Field.IsGameOver = true;
            }
        }
    }
}
