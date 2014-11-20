using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class MenuState : AGameState
    {
        private BitmapImage play;
        private Point playButton = new Point(100, 200);

        public MenuState(GameStateManager manager, int level = 0) : base(manager, level) { }

        public override void OnEntering()
        {

        }

        public override void HandleClick(System.Windows.Point p)
        {
            if (p.X >= playButton.X && p.X <= playButton.X + play.PixelWidth && p.Y >= playButton.Y && p.Y <= playButton.Y + play.PixelHeight)
            {
                // Go to gamestate       
                manager.Switch(new PlayingState(manager, level));
            }
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {

        }

        public override void Init(Tiwi.Window window)
        {
            window.Title = "Pacman";
            window.Width = 400;
            window.Height = 220;
            BitmapImage splash = new BitmapImage(new Uri(@"../../../assets/splash.png", UriKind.Relative));
            play = new BitmapImage(new Uri(@"../../../assets/play.png", UriKind.Relative));
            window.DrawImage(new Point(10, 50), new Size(splash.PixelWidth, splash.PixelHeight), splash);
            window.DrawImage(playButton, new Size(play.PixelWidth, play.PixelHeight), play);
        }
    }
}
