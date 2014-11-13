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
        private IGameObject[,] gameObjects;
        private IList<AMoveable> moveableObjects;
        private int score;
        private SolidColorBrush wallColor, dotColor;

        public GameWindow()
        {
            Init();
            DrawGame();
            TickInterval = new TimeSpan(0, 0, 0, 0, 500);
            StartTimer();
        }

        public void Init()
        {
            this.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            ADirector director = new DirectorFromFile(@"../../../Assets/config.txt");
            gameObjects = director.Construct(new Builder());
            wallColor = new SolidColorBrush(Color.FromRgb(0x00, 0x2C, 0xD2));
            dotColor = new SolidColorBrush(Color.FromRgb(0XF1, 0XAC, 0X8B));
            Width = gameObjects.GetLength(1) * 20;
            Height = gameObjects.GetLength(0) * 20;
        }

        public void DrawGame()
        {
            for (int i = 0; i < gameObjects.GetLength(0); i++)
            {
                for (int j = 0; j < gameObjects.GetLength(1); j++)
                {
                    gameObjects[i, j].Draw(this, new Vector2D(j * 20, i * 20));
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
