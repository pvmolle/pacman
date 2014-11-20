namespace Pacman
{
    internal class StrategyFleeing : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            gameObject.Direction = MazeSolver.SolveForDirection(gameObject.Field, gameObject.Location, gameObject.Field.Pacman.Location, false);
            gameObject.Speed = .2;
        }
    }
}