﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public abstract class ADirector
    {
        protected string[,] objects;
        protected PositionVector dimension;

        public abstract IGameObject[,] Construct(ABuilder builder);
    }
}