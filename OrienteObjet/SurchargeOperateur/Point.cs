﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteObjet.SurchargeOperateur
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator == (Point p1, Point p2)
        {
            if (object.ReferenceEquals(p1, p2))
                return true;

            if (p1 == null || p2 == null)
                return false;

            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X || (p1.X == p2.X && p1.Y < p2.Y);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X || (p1.X == p2.X && p1.Y > p2.Y);
        }

        public static bool operator <=(Point p1, Point p2)
        {
            return !(p1 > p2); 
        }

        public static bool operator >=(Point p1, Point p2)
        {
            return !(p1 < p2);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point other)
            {
                return this == other; 
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}
