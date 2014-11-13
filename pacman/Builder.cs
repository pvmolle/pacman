using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Builder : ABuilder
    {
        public override void AddGameObject(string type)
        {
            IGameObject gameObject;

            switch (type)
            {
                case "pacman":
                    gameObject = new Pacman(objects);
                    break;
                default:
                    throw new Exception("Invalid part type");
            }

            objects[indexY, indexX] = gameObject;
            indexX++;
            if (indexX >= objects.GetLength(0))
            {
                indexY++;
                indexX = 0;
            }
        }
    }
}
