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
                return "../../../assets/inky.png";
            }
        }

        public EnemyInky(AGameObject[,] objects, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(objects, location, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
