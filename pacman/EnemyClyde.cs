using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyClyde : Enemy
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
                    return "../../../assets/clyde.png";
                }
            }
        }

        public EnemyClyde(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
