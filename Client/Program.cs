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
            MenuWindow window = new MenuWindow();
            window.Background = Brushes.LightGray;
            window.ShowDialog();

           // Console.ReadKey();
        }
    }
}
