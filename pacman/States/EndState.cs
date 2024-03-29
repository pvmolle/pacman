﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Pacman
{
    public class EndState : AGameState
    {
        private BitmapImage logo;
        private BitmapImage play;
        private Point continueButton;

        public EndState(GameStateManager manager, int level = 0)
            : base(manager, level)
        {
        }

        public override void HandleClick(System.Windows.Point p)
        {
            if (p.X >= continueButton.X && p.X <= continueButton.X + play.PixelWidth && p.Y >= continueButton.Y && p.Y <= continueButton.Y + play.PixelHeight)
            {
                manager.Switch(new MenuState(manager, 0));
            }
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                manager.Switch(new MenuState(manager, 0));
            }
        }

        public override void Init(Tiwi.Window window)
        {
            window.ClearWindow();
            logo = new BitmapImage(new Uri(@"../../../assets/logo.png", UriKind.Relative));
            int x = 420 / 2 - logo.PixelWidth / 4;
            int y = 50;
            window.DrawImage(new Point(x, y), new Size(logo.PixelWidth / 2, logo.PixelHeight / 2), logo);
            BitmapImage go = new BitmapImage(new Uri(@"../../../assets/game-over.png", UriKind.Relative));
            x = 420 / 2 - go.PixelWidth / 2;
            y += 100;
            window.DrawImage(new Point(x, y), new Size(go.PixelWidth, go.PixelHeight), go);
            play = new BitmapImage(new Uri(@"../../../assets/continue.png", UriKind.Relative));
            continueButton.X = 420 / 2 - play.PixelWidth / 2;
            continueButton.Y = y + 200;
            window.DrawImage(continueButton, new Size(play.PixelWidth, play.PixelHeight), play);
        }
    }
}