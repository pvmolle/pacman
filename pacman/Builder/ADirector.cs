namespace Pacman
{
    public abstract class ADirector
    {
        protected string[,] objects;
        protected Vector2D dimension;

        public abstract Field Construct(ABuilder builder);
    }
}