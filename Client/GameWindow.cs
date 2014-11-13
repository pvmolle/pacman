using Pacman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class GameWindow : Tiwi.Window
    {
        private IGameObject[,] gameObjects;
        private IList<AMoveable> moveableObjects;
        private int score;

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
        }

        public void Draw()
        {

        }

        protected override void TimerTick()
        {
            base.TimerTick();
            ClearWindow();
            
            // TODO
            Draw();
        }
    }
}
