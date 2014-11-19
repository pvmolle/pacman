using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Pacman
{
    public class Wall : AGameObject
    {
        private static Size size = new Size(20, 20);
        private static SolidColorBrush wallColor;

        public Wall(Vector2D location) : base(location) { }

        static Wall()
        {
            wallColor = new SolidColorBrush(Color.FromRgb(0x00, 0x2C, 0xD2));
            wallColor.Freeze();
        }

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawRectangle(new Point(position.X, position.Y), size, wallColor, wallColor);
        }
    }
}
