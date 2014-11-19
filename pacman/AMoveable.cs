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
        public static List<Vector2D> Directions;

        internal Field Field { get; set; }
        internal double Position { get; set; }
        internal Vector2D Direction { get; set; }
        public double Speed { get; set; }
        private BitmapImage moveable;
        protected Size size = new Size(20, 20);
        protected abstract string Resource { get; }
        protected AGameObject objectCovered;

        public AMoveable(Field field, Vector2D location)
            : base(location)
        {
            Direction = new Vector2D(1, 0);
            Field = field;
        }

        static AMoveable()
        {
            Directions = new List<Vector2D>();
            Directions.Add(new Vector2D(1, 0));
            Directions.Add(new Vector2D(-1, 0));
            Directions.Add(new Vector2D(0, 1));
            Directions.Add(new Vector2D(0, -1));
        }

        public abstract void Loop();

        public virtual void Move()
        {
            Position += Speed;
            if (Position >= 1)
            {
                int x = Location.X + Direction.X;
                int y = Location.Y + Direction.Y;
                
                AGameObject target = Field.GameObjects[y, x];
                if (target is Wall || (this is Enemy && target is Enemy))
                {
                    return;
                }

                Position = 0;
                AGameObject previousObjectCovered = objectCovered;
                objectCovered = Field.GameObjects[y, x];
                Field.GameObjects[y, x] = this;
                Field.GameObjects[Location.Y, Location.X] = previousObjectCovered;
                Location.Y = y;
                Location.X = x;
            }
        }

        public override void Draw(Tiwi.Window window, Vector2D position)
        {
            moveable = new BitmapImage(new Uri(Resource, UriKind.Relative));
            window.DrawImage(new Point(position.X, position.Y), size, moveable);
        }
    }
}
