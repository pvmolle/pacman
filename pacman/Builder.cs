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
                case "wall":
                    gameObject = new Wall();
                    break;
                case "dot":
                    gameObject = new Dot();
                    break;
                case "powerup":
                    gameObject = new Powerup();
                    break;
                case "clyde":
                    gameObject = new EnemyClyde(objects, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "inky":
                    gameObject = new EnemyInky(objects, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "pinky":
                    gameObject = new EnemyPinky(objects, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "blinky":
                    gameObject = new EnemyBlinky(objects, new StrategyClyde(), new StrategyFleeing());
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
