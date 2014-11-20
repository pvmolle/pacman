using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class MenuState : AGameState
    {
        private BitmapImage logo;
        private BitmapImage play;
        private Point playButton;

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
            window.Background = Brushes.Black;
            window.Width = 420;
            window.Height = 460;
            logo = new BitmapImage(new Uri(@"../../../assets/logo.png", UriKind.Relative));
            int x = 420 / 2 - logo.PixelWidth / 4;
            int y = 50;
            window.DrawImage(new Point(x, y), new Size(logo.PixelWidth / 2, logo.PixelHeight / 2), logo);
            play = new BitmapImage(new Uri(@"../../../assets/play.png", UriKind.Relative));
            playButton.X = 420 / 2 - play.PixelWidth / 2;
            playButton.Y = 250;
            window.DrawImage(playButton, new Size(play.PixelWidth, play.PixelHeight), play);
        }
    }
}
