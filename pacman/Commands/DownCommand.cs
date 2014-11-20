namespace Pacman
{
    public class DownCommand : ACommand
    {
        public DownCommand(Pacman pacman)
            : base(pacman)
        {
        }

        public override void Execute()
        {
            pacman.Speed = 1;
            pacman.Direction = new Vector2D(0, 1);
        }
    }
}