using System.Windows;

namespace Pacman
{
    public class Powerup : Dot
    {
        private static Size size = new Size(12, 12);

        public Powerup(Vector2D location)
            : base(location)
        {
            Points = 50;
        }

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawEllipse(new Point(position.X + 4, position.Y + 4), size, dotColor, dotColor);
        }
    }
}