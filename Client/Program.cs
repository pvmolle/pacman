using System;

namespace Client
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            GameWindow window = new GameWindow();
            window.ShowDialog();
        }
    }
}