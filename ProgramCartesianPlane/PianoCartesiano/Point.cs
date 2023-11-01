using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PianoCartesiano
{
    public class Point
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Point(int coordinateX=0, int coordinateY=0)
        {
            X = coordinateX;
            Y = coordinateY;
        }

        //campo calcolato --> proprietà di sola lettura
        public int Quadrant()
        {      
            int position;
            if (X > 0 && Y > 0)
            {
                position = 1;
            }
            else if (X < 0 && Y > 0)
            {
                position = 2;
            }
            else if (X < 0 && Y < 0)
            {
                position = 3;
            }
            else if (X > 0 && Y < 0)
            {
                position = 4;
            }
            else
            {
                throw new Exception("Il punto non è in nessun quadrante");
            }

            return position;


        }

        public void translateX(int newX)
        {
            X += newX;
        }
        public void translateY(int newY)
        {
            Y += newY;
        }

        //ridefinisco (override) il comportamento del metodo Equals
        public override bool Equals(object? obj)
        {
            Point p = (Point)obj;
            if (X == p.X && Y == p.Y)
                return true;
            return false;

        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}

