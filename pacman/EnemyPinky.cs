using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyPinky : Enemy
    {
        public static IStrategy defaultStrategy;
        public const string Resource = "../../../assets/pinky.png";

        public override bool IsFleeing
        {
            get
            {
                return IsFleeing;
            }
            set
            {
                IsFleeing = value;
                if (IsFleeing)
                {
                    strategy = new StrategyFleeing();
                }
                else
                {
                    strategy = EnemyPinky.defaultStrategy;
                }
            }
        }

        public EnemyPinky(IStrategy strategy)
            : base(strategy)
        {
        }
    }
}
