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
        private AGameObject[,] objects;
        internal Vector2D Direction { get; set; }
        private BitmapImage moveable;
        protected Size size = new Size(20, 20);
        protected abstract string Resource { get; }

        public AMoveable(AGameObject[,] objects)
        {
            Direction = new Vector2D(1, 0);
            this.objects = objects;
            moveable = new BitmapImage(new Uri(Resource, UriKind.Relative));
        }

        public abstract void Loop();

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            window.DrawImage(new Point(position.X, position.Y), size, moveable);
        }
    }
}
