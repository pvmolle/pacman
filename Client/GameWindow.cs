using Pacman;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Client
{
    class GameWindow : Tiwi.Window
    {
        private GameStateManager manager;


        public GameWindow()
        {
            AGameState m = new MenuState(manager);
            manager = new GameStateManager(m, this);
            m.Manager = manager;
            TickInterval = new TimeSpan(0, 0, 0, 0, 68); // 15 FPS
            StartTimer();
        }

        protected override void TimerTick()
        {
            base.TimerTick();
            manager.Tick();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            manager.KeyDownHandler(e); 
        }

        protected override void LeftMouseClick(Point p)
        {
            base.LeftMouseClick(p);
            manager.ClickHandler(p);
        }
    }
}
