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
                manager.Switch(new PlayingState(manager, level));
            }
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                manager.Switch(new PlayingState(manager, level));
            }
        }

        public override void Init(Tiwi.Window window)
        {
            window.ClearWindow();
            window.Title = "Pacman";
            window.Background = Brushes.Black;
            window.Width = 420;
            window.Height = 460;
            logo = new BitmapImage(new Uri(@"../../../assets/logo.png", UriKind.Relative));
            int x = 420 / 2 - logo.PixelWidth / 4;
            int y = 50;
            window.DrawImage(new Point(x, y), new Size(logo.PixelWidth / 2, logo.PixelHeight / 2), logo);
            BitmapImage go = new BitmapImage(new Uri(@"../../../assets/new-game.png", UriKind.Relative));
            x = 420 / 2 - go.PixelWidth / 2;
            y += 100;
            window.DrawImage(new Point(x, y), new Size(go.PixelWidth, go.PixelHeight), go);
            play = new BitmapImage(new Uri(@"../../../assets/play.png", UriKind.Relative));
            playButton.X = 420 / 2 - play.PixelWidth / 2;
            playButton.Y = y + 200;
            window.DrawImage(playButton, new Size(play.PixelWidth, play.PixelHeight), play);
        }
    }
}
