using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Vector2D
    {
        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Vector2D v = obj as Vector2D;
            return this.X == v.X && this.Y == v.Y;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
