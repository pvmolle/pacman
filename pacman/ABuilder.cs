using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class ABuilder
    {
        protected IGameObject[,] objects;
        protected int indexX, indexY;
        protected Vector dimension;

        public ABuilder()
        {
            indexX = 0;
            indexY = 0;
        }

        public void SetDimension(Vector dimension)
        {
            this.dimension = dimension;
        }

        public abstract void AddGameObject(string type);

        public IGameObject[,] GetWorld()
        {
            return objects;
        }
    }
}
