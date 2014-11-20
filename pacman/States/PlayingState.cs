using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace Pacman
{
    public class PlayingState : AGameState, IDrawable, ILoopable
    {
        private Field field;
        private UpCommand upCommand = new UpCommand();
        private DownCommand downCommand = new DownCommand();
        private LeftCommand leftCommand = new LeftCommand();
        private RightCommand rightCommand = new RightCommand();

        public PlayingState(GameStateManager manager, int level) : base(manager, level) { }

        public void Draw(Tiwi.Window window)
        {
            window.ClearWindow();
            for (int i = 0; i < field.GameObjects.GetLength(0); i++)
            {
                for (int j = 0; j < field.GameObjects.GetLength(1); j++)
                {
                    AGameObject gameObject;
                    if ((gameObject = field.GameObjects[i, j]) != null)
                    {
                        field.GameObjects[i, j].Draw(window, new Vector2D(j * 20, i * 20));
                    }
                }
            }
        }

        public void Loop(Tiwi.Window window)
        {
            field.Pacman.Loop();
            foreach (Enemy enemy in field.Enemies)
            {
                enemy.Loop();
            }
            if (field.IsGameOver)
            {
                manager.Switch(new EndState(manager, level));
            }
            else if (field.AllDotsCleared)
            {
                manager.Switch(new MenuState(manager, level));
            }
        }

        public override void Init(Tiwi.Window window)
        {
            window.Title = "Pacman - Score: 0";
            window.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            ADirector director = new DirectorFromFile(@"../../../Assets/config.txt");
            field = director.Construct(new Builder());
            window.Width = field.GameObjects.GetLength(1) * 20;
            window.Height = field.GameObjects.GetLength(0) * 20;
        }

        public override void OnEntering()
        {
        }

        public override void HandleClick(System.Windows.Point p)
        {
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {
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
