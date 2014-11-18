using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class AGameObject
    {
        private int points = 0;

        protected int Points
        {
            get { return points; }
            set { points = value; }
        }
        
        public abstract void Draw(Tiwi.Window window, Vector2D position);
    }
}
