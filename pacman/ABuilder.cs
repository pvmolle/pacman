using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    abstract class ABuilder
    {
        internal IGameObject[][] objects;
        internal int indexX, indexY;

        public ABuilder()
        {
            indexX = 0;
            indexY = 0;
        }

        public abstract void BuildPart(string type);

        public IGameObject[][] GetWorld()
        {
            return objects;
        }
    }
}
