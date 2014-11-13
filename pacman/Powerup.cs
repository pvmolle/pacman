using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Pacman
{
    public class Powerup : Dot
    {
        private static Size size = new Size(12, 12);

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawEllipse(new Point(position.X + 4, position.Y + 4), size, dotColor, dotColor);
        }
    }
}
