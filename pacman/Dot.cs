using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Pacman
{
    public class Dot : IGameObject
    {
        private static Size size = new Size(8, 8);
        protected static SolidColorBrush dotColor = new SolidColorBrush(Color.FromRgb(0XF1, 0XAC, 0X8B));


        public virtual void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawEllipse(new Point(position.X + 6, position.Y + 6), size, dotColor, dotColor);
        }
    }
}
