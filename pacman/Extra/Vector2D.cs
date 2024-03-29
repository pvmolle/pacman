﻿using System;

namespace Pacman
{
    public class Vector2D
    {
        public Vector2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Vector2D()
        {
        }

        public Vector2D(Vector2D v)
        {
            this.X = v.X;
            this.Y = v.Y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Vector2D v = obj as Vector2D;
            return this.X == v.X && this.Y == v.Y;
        }

        public void Add(Vector2D v)
        {
            this.X += v.X;
            this.Y += v.Y;
        }

        public double Distance(Vector2D v)
        {
            double a = this.X - v.X;
            double b = this.Y - v.Y;
            return Math.Sqrt(a * a + b * b);
        }

        public Vector2D GetDistanceVector(Vector2D v)
        {
            Vector2D distanceVector = new Vector2D();
            distanceVector.X = GetDistance(this.X, v.X);
            distanceVector.Y = GetDistance(this.Y, v.Y);
            return distanceVector;
        }

        private int GetDistance(int p1, int p2)
        {
            int difference = p2 - p1;
            if (difference != 0)
            {
                difference /= Math.Abs(difference);
            }
            return difference;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}