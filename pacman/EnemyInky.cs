using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyInky : Enemy
    {
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
                    return "../../../assets/inky.png";
                }
            }
        }

        public EnemyInky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
