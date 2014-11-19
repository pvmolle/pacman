using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows;

namespace Client
{
    class MenuWindow : Tiwi.Window
    {
        private BitmapImage play;
        private Point playButton = new Point(100, 200);
        public MenuWindow()
        {
            Title = "Pacman";           
            BitmapImage splash = new BitmapImage(new Uri(@"../../../assets/splash.png", UriKind.Relative));
            play = new BitmapImage(new Uri(@"../../../assets/play.png", UriKind.Relative));
            DrawImage(new Point(10, 50), new Size(splash.PixelWidth, splash.PixelHeight), splash);
            DrawImage(playButton, new Size(play.PixelWidth, play.PixelHeight), play);
        }

        protected override void LeftMouseClick(System.Windows.Point p)
        {
            base.LeftMouseClick(p);
            if (p.X >= playButton.X && p.X <= playButton.X + play.PixelWidth && p.Y >= playButton.Y && p.Y <= playButton.Y + play.PixelHeight)
            {
                // start game and close window
                this.Hide();
                GameWindow game = new GameWindow();
                game.Closed += (sender, args) => this.Close();
                game.ShowDialog();
            }
        }
    }
}
