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
        public MenuWindow()
        {
            Title = "Pacman";           
            BitmapImage splash = new BitmapImage(new Uri(@"../../../assets/splash.png", UriKind.Relative));
            play = new BitmapImage(new Uri(@"../../../assets/play.png", UriKind.Relative));
            DrawImage(new Point(10, 50), new Size(splash.PixelWidth, splash.PixelHeight), splash);
            DrawImage(new Point(100, 200), new Size(play.PixelWidth, play.PixelHeight), play);
        }

        protected override void LeftMouseClick(System.Windows.Point p)
        {
            base.LeftMouseClick(p);
            if (p.X >= 100 && p.X <= 100 + play.PixelWidth && p.Y >= 200 && p.Y <= 200 + play.PixelHeight)
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
