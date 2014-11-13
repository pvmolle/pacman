using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyBlinky : Enemy
    {
        public static IStrategy defaultStrategy;
        public const string Resource = "../../../assets/blinky.png";

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
                    strategy = EnemyBlinky.defaultStrategy;
                }
            }
        }

        public EnemyBlinky(IStrategy strategy)
            : base(strategy)
        {
        }

        public void Draw(Tiwi.Window window)
        {
            throw new NotImplementedException();
        }
    }
}
