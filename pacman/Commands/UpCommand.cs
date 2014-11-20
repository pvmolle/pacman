namespace Pacman
{
    public class UpCommand : ICommand
    {
        public void Execute(Pacman pacman)
        {
            pacman.Speed = 1;
            pacman.Direction = new Vector2D(0, -1);
        }
    }
}