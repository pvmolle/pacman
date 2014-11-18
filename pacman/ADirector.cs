using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class ADirector
    {
        protected string[,] objects;
        protected Vector2D dimension;

        public abstract AGameObject[,] Construct(ABuilder builder);
    }
}
