namespace Pacman
{
    public class RightCommand : ACommand
    {
        public RightCommand(Pacman pacman)
            : base(pacman)
        {
        }

        public override void Execute()
        {
            pacman.Speed = 1;
            pacman.Direction = new Vector2D(1, 0);
        }
    }
}