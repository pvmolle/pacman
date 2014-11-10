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
                    strategy = EnemyClyde.defaultStrategy;
                }
            }
        }

        public EnemyClyde(IStrategy strategy) : base(strategy)
        {
        }
    }
}
