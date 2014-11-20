using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class GameStateManager
    {
        private IGameState currentState;
        private IDrawable drawable;
        private ILoopable loopable;

        public void Switch(IGameState newState)
        {
            this.currentState = newState;
        }

        public void Draw(Tiwi.Window window)
        {
            drawable.Draw(window);
        }

        private void SetDrawableAndLoopAble(IGameState state) {
            drawable = state is IDrawable ? (IDrawable)state : null;
            loopable = state is ILoopable ? (ILoopable)state : null;
        }
    }
}
