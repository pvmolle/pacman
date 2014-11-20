using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class EndState : AGameState
    {
        public EndState(GameStateManager manager, int level = 0) : base(manager, level) { }

        public override void OnEntering()
        {
        }

        public override void HandleClick(System.Windows.Point p)
        {
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {
        }

        public override void Init(Tiwi.Window window)
        {
        }
    }
}
