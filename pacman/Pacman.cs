using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Pacman : AMoveable
    {
        public string Resource
        {
            get
            {
                string resource;
                if (Direction.X == 0)
                {
                    if (Direction.Y == 1)
                    {
                        resource = "../../../assets/pacman-up.png";
                    }
                    else
                    {
                        resource = "../../../assets/pacman-down.png";
                    }
                }
                else
                {
                    if (Direction.X == -1)
                    {
                        resource = "../../../assets/pacman-left.png";
                    }
                    else
                    {
                        resource = "../../../assets/pacman-right.png";
                    }
                }

                return resource;
            }
        }

        public Pacman(IGameObject[,] objects)
            : base(objects)
        {

        }

        public void MoveUp()
        {
            throw new NotImplementedException();
        }

        public void MoveDown()
        {
            throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            throw new NotImplementedException();
        }

        public void MoveRight()
        {
            throw new NotImplementedException();
        }

        public override void Loop()
        {
            throw new NotImplementedException();
        }
    }
}
