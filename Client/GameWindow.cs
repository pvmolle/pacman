using Pacman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Client
{
    class GameWindow : Tiwi.Window
    {
        private Field field;
        private int score;

        public GameWindow()
        {
            Init();
            Title = "Pacman";
            DrawGame();
            TickInterval = new TimeSpan(0, 0, 0, 0, 500);
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
                    field.GameObjects[i, j].Draw(this, new Vector2D(j * 20, i * 20));
                }
            }
        }

        protected override void TimerTick()
        {
            base.TimerTick();
            ClearWindow();
            DrawGame();
        }
    }
}
