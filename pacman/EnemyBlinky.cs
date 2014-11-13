using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class EnemyBlinky : Enemy
    {
        public static IStrategy defaultStrategy;
        protected override string Resource
        {
            get
            {
                return "../../../assets/blinky.png";
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
