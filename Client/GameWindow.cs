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
        private Field field;
        private UpCommand upCommand = new UpCommand();
        private DownCommand downCommand = new DownCommand();
        private LeftCommand leftCommand = new LeftCommand();
        private RightCommand rightCommand = new RightCommand();

        public GameWindow()
        {
            Init();
            Title = "Pacman - Score: 0";
            DrawGame();
            TickInterval = new TimeSpan(0, 0, 0, 0, 68); // 15 FPS
            StartTimer();
        }

        public void Init()
        {
            this.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            ADirector director = new DirectorFromFile(@"../../../Assets/config.txt");
            field = director.Construct(new Builder());
            Width = field.GameObjects.GetLength(1) * 20;
            Height = field.GameObjects.GetLength(0) * 20;
        }

        public void DrawGame()
        {
            for (int i = 0; i < field.GameObjects.GetLength(0); i++)
            {
                for (int j = 0; j < field.GameObjects.GetLength(1); j++)
                {
                    AGameObject gameObject;
                    if ((gameObject = field.GameObjects[i, j]) != null)
                    {
                        field.GameObjects[i, j].Draw(this, new Vector2D(j * 20, i * 20));
                    }
                }
            }
        }

        protected override void TimerTick()
        {
            base.TimerTick();
            if (field.IsGameOver)
            {
                Title = "Pacman";
                this.DrawRectangle(new Point((this.Width / 2) - 60, (this.Height / 2) - 5), new Size(135, 45), Brushes.White, Brushes.White);
                this.DrawText(new Point((this.Width / 2) - 50, this.Height / 2), Brushes.Black, Brushes.White, "Game Over!\nYou scored " + field.Score + " points");
            }
            else if (field.AllDotsCleared())
            {
                Title = "Pacman - Score: " + field.Score;
            }
            else
            {
                GameLoop();
                Title = "Pacman - Score: " + field.Score;
            }
        }

        public void GameLoop()
        {
            ClearWindow();
            field.Pacman.Loop();
            foreach (Enemy enemy in field.Enemies)
            {
                enemy.Loop();
            }
            field.Pacman.DetectCollision();
            DrawGame();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.Key)
            {
                case (Key.Left):
                    leftCommand.Execute(field.Pacman);
                    break;
                case (Key.Right):
                    rightCommand.Execute(field.Pacman);
                    break;
                case (Key.Up):
                    upCommand.Execute(field.Pacman);
                    break;
                case (Key.Down):
                    downCommand.Execute(field.Pacman);
                    break;
            }
        }
    }
}
