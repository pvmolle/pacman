using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    /// <summary>
    /// Blinky is a Red Ghost that is Bad-Tempered and Bossy.
    /// Blinky receives a speed boost after a number of pac-pellets have been cleared. 
    /// </summary>
    class StrategyBlinky : IStrategy
    {
        public void Loop(AMoveable gameObject)
        {
            AGameObject[,] objects = gameObject.Field.GameObjects;
            int height = objects.GetLength(0);
            int width = objects.GetLength(1);
            int max = Math.Max(height, width);
            int[,] field = new int[height, width];

            // Locate Pacman
            


        }

        private void SetValue(int[,] field, int startY, int startX, int value)
        {

        }
    }
}
