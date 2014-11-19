using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class EnemyBlinky : Enemy
    {
        public static IStrategy defaultStrategy;
        protected override string Resource
        {
            get
            {
                if (IsFleeing)
                {
                    return "../../../assets/ghost.png";
                }
                else
                {
                    return "../../../assets/blinky.png";
                }           
            }
        }

        public EnemyBlinky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {
            
        }

    }
}
