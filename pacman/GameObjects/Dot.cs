using System.Windows;
using System.Windows.Media;

namespace Pacman
{
    public class Dot : AGameObject
    {
        private static Size size = new Size(6, 6);
        protected static SolidColorBrush dotColor;

        public Dot(Vector2D location)
            : base(location)
        {
            Points = 10;
        }

        static Dot()
        {
            dotColor = new SolidColorBrush(Color.FromRgb(0xF1, 0xAC, 0x8B));
            dotColor.Freeze();
        }

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawEllipse(new Point(position.X + 6, position.Y + 6), size, dotColor, dotColor);
        }
    }
}