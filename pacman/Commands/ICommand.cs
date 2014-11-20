namespace Pacman
{
    internal delegate void Invoker();

    internal interface ICommand
    {
        // public Invoker Up, Down, Left, Right;

        void Execute(Pacman pacman);
    }
}