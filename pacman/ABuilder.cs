using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class ABuilder
    {
        protected AGameObject[,] objects;
        protected int indexX, indexY;
        protected Vector2D dimension;

        public ABuilder()
        {
            indexX = 0;
            indexY = 0;
        }

        public void SetDimension(Vector2D dimension)
        {
            this.dimension = dimension;
            objects = new AGameObject[dimension.Y, dimension.X];
        }

        public abstract void AddGameObject(string type);

        public AGameObject[,] GetWorld()
        {
            return objects;
        }
    }
}
