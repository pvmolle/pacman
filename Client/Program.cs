using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Client
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow();
            window.ShowDialog();
        }
    }
}
