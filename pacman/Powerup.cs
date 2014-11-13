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
        private static Size size = new Size(20, 20);

        public override void Draw(Tiwi.Window window, PositionVector position)
        {
            window.DrawEllipse(new Point(position.X, position.Y), new Size(10, 10), dotColor, dotColor);
        }
    }
}
