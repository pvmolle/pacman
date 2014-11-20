using System.Windows;
using System.Windows.Input;

namespace Pacman
{
    public delegate void ClickHandler(Point p);

    public delegate void KeyDownHandler(KeyEventArgs e);

    public class GameStateManager
    {
        public ClickHandler ClickHandler { get; set; }

        public KeyDownHandler KeyDownHandler { get; set; }

        private AGameState currentState;
        private IDrawable drawable;
        private ILoopable loopable;
        private Tiwi.Window window;

        public GameStateManager(AGameState state, Tiwi.Window window)
        {
            this.window = window;
            Switch(state);
        }

        public void Switch(AGameState newState)
        {
            currentState = newState;
            SetDrawableAndLoopAble(currentState);
            ClickHandler = newState.HandleClick;
            KeyDownHandler = newState.HandleKeyDown;
            currentState.Init(window);
        }

        public void Tick()
        {
            if (loopable != null)
            {
                loopable.Loop(window);
            }
            if (drawable != null)
            {
                drawable.Draw(window);
            }
        }

        private void SetDrawableAndLoopAble(AGameState state)
        {
            drawable = state is IDrawable ? (IDrawable)state : null;
            loopable = state is ILoopable ? (ILoopable)state : null;
        }
    }
}