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
            TickInterval = new TimeSpan(0, 0, 0, 0, 500);
            StartTimer();
        }

        public void Init()
        {   
            ADirector director = new DirectorFromFile(@"../../../Assets/config.txt");
            gameObjects = director.Construct(new Builder());
            wallColor = new SolidColorBrush(Color.FromRgb(0x00, 0x2C, 0xD2));
            dotColor = new SolidColorBrush(Color.FromRgb(0XF1, 0XAC, 0X8B));
        }

        public void Draw()
        {
            for (int i = 0; i < gameObjects.GetLength(0); i++)
            {
                for (int j = 0; j < gameObjects.GetLength(1); j++)
                {
                    gameObjects[i, j].Draw(this, new PositionVector(0,0));
                }
            }
        }

        protected override void TimerTick()
        {
            base.TimerTick();
            ClearWindow();
            
            Draw();
        }
    }
}
