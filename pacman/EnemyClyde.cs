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
                return "../../../assets/clyde.png";
            }
        }

        public EnemyClyde(AGameObject[,] objects, Vector2D location, IStrategy attackingStrategy, IStrategy fleeingStrategy)
            : base(objects, location, attackingStrategy, fleeingStrategy)
        {

        }

    }
}
