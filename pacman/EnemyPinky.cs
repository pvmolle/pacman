using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyPinky : Enemy
    {
        protected override string Resource
        {
            get
            {
                return "../../../assets/pinky.png";
            }
        }

        public EnemyPinky(Field field, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(field, location, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
