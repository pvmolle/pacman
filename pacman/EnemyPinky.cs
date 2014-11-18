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

        public EnemyPinky(AGameObject[,] objects, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(objects, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
