using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Builder : ABuilder
    {
        public override void AddGameObject(string type)
        {
            AGameObject gameObject;
            Vector2D location = new Vector2D(indexX, indexY);

            switch (type)
            {
                case "pacman":
                    gameObject = new Pacman(objects, location);
                    break;
                case "wall":
                    gameObject = new Wall(location);
                    break;
                case "dot":
                    gameObject = new Dot(location);
                    break;
                case "powerup":
                    gameObject = new Powerup(location);
                    break;
                case "clyde":
                    gameObject = new EnemyClyde(objects, location, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "inky":
                    gameObject = new EnemyInky(objects, location, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "pinky":
                    gameObject = new EnemyPinky(objects, location, new StrategyClyde(), new StrategyFleeing());
                    break;
                case "blinky":
                    gameObject = new EnemyBlinky(objects, location, new StrategyClyde(), new StrategyFleeing());
                    break;
                default:
                    throw new Exception("Invalid part type");
            }

            objects[indexY, indexX] = gameObject;
            indexX++;
            if (indexX >= objects.GetLength(1))
            {
                indexY++;
                indexX = 0;
            }
        }
    }
}
