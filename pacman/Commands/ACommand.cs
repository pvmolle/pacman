namespace Pacman
{
    public abstract class ACommand
    {
        protected Pacman pacman;

        public ACommand(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public abstract void Execute();
    }
}