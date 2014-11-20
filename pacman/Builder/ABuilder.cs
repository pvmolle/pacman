using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class ABuilder
    {
        protected Field field;
        protected int indexX, indexY;
        protected Vector2D dimension;

        public ABuilder()
        {
            indexX = 0;
            indexY = 0;
            field = new Field();
        }

        public void SetDimension(Vector2D dimension)
        {
            this.dimension = dimension;
            field.GameObjects = new AGameObject[dimension.Y, dimension.X];
        }

        public abstract void AddGameObject(string type);

        public Field GetWorld()
        {
            return field;
        }
    }
}
