using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class AMoveable : IGameObject
    {
        private IGameObject[,] objects;
        public PositionVector Direction { get; set; }

        public AMoveable(IGameObject[,] objects)
        {
            this.objects = objects;
        }

        public AMoveable() { }

        public abstract void Loop();

        public void Draw(Tiwi.Window window)
        {
            throw new NotImplementedException();
        }
    }
}
