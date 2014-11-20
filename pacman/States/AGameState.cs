using System.Windows;
using System.Windows.Input;

namespace Pacman
{
    public abstract class AGameState
    {
        protected GameStateManager manager;
        protected int level;

        public GameStateManager Manager
        {
            set
            {
                manager = value;
            }
        }

        public AGameState(GameStateManager manager, int level = 0)
        {
            this.manager = manager;
            this.level = level;
        }

        public abstract void Init(Tiwi.Window window);

        public abstract void HandleClick(Point p);

        public abstract void HandleKeyDown(KeyEventArgs e);
    }
}