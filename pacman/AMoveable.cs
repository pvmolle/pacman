using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public abstract class AMoveable : AGameObject
    {
        internal Field Field { get; set; }
        internal Vector2D Direction { get; set; }
        private BitmapImage moveable;
        protected Size size = new Size(20, 20);
        protected abstract string Resource { get; }

        public AMoveable(Field field, Vector2D location) : base(location)
        {
            Direction = new Vector2D(1, 0);
            Field = field;
            moveable = new BitmapImage(new Uri(Resource, UriKind.Relative));
        }

        public abstract void Loop();

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawImage(new Point(position.X, position.Y), size, moveable);
        }
    }
}
