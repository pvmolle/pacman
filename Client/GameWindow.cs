using Pacman;
using System;
using System.Windows;
using System.Windows.Input;

namespace Client
{
    internal class GameWindow : Tiwi.Window
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