﻿namespace Pacman
{
    public abstract class AGameObject
    {
        private int points = 0;

        internal Vector2D Location { get; set; }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public AGameObject(Vector2D location)
        {
            Location = location;
        }

        public abstract void Draw(Tiwi.Window window, Vector2D position);
    }
}