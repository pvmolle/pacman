using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    abstract class AMoveable : AMoveable
    {
        private AMoveable[][] game;

        public AMoveable()
        {
            // TODO
        }

        public AMoveable(AMoveable[][] game)
        {
            this.game = game;
        }

        void AMoveable.Loop()
        {
            throw new NotImplementedException();
        }
    }
}
