using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EnemyInky : Enemy
    {
        public static IStrategy defaultStrategy;
        protected override string Resource
        {
            get
            {
                return "../../../assets/inky.png";
            }
        }

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
                    strategy = EnemyInky.defaultStrategy;
                }
            }
        }

        public EnemyInky(IStrategy strategy)
            : base(strategy)
        {
        }

        public void Draw(Tiwi.Window window)
        {
            throw new NotImplementedException();
        }
    }
}
