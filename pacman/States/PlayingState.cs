using System;
using System.Windows.Input;
using System.Windows.Media;

namespace Pacman
{
    public class PlayingState : AGameState, IDrawable, ILoopable
    {
        private Field field;
        private ACommand upCommand, downCommand, leftCommand, rightCommand;

        public PlayingState(GameStateManager manager, int level = 0)
            : base(manager, level)
        {
        }

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
            if (field.IsGameOver)
            {
                manager.Switch(new EndState(manager, level));
            }
            else if (field.IsGameWon)
            {
                manager.Switch(new MenuState(manager, (level + 1) % 2));
            }
            field.Pacman.Loop();
            foreach (Enemy enemy in field.Enemies)
            {
                enemy.Loop();
            }
            window.Title = "Pacman - Score: " + field.Score;
        }

        public override void Init(Tiwi.Window window)
        {
            window.Title = "Pacman - Score: 0";
            window.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            ADirector director = new DirectorFromFile(String.Format(@"../../../Assets/{0}.txt", level));
            field = director.Construct(new Builder());
            window.Width = field.GameObjects.GetLength(1) * 20;
            window.Height = field.GameObjects.GetLength(0) * 20;

            upCommand = new UpCommand(field.Pacman);
            downCommand = new DownCommand(field.Pacman);
            leftCommand = new LeftCommand(field.Pacman);
            rightCommand = new RightCommand(field.Pacman);
        }

        public override void HandleClick(System.Windows.Point p)
        {
        }

        public override void HandleKeyDown(System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case (Key.Left):
                    leftCommand.Execute();
                    break;

                case (Key.Right):
                    rightCommand.Execute();
                    break;

                case (Key.Up):
                    upCommand.Execute();
                    break;

                case (Key.Down):
                    downCommand.Execute();
                    break;
            }
        }
    }
}