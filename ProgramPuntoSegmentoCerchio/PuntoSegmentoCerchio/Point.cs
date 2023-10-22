using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoSegmentoCerchio
{
    public class Point
    {
        private double _coordinateX;
        private double _coordinateY;

        public double CoordinateX
        {
            get { return _coordinateX; }
            set { _coordinateX = value; }
        }
        public double CoordinateY { get { return _coordinateY; } set { _coordinateY = value; } }
        public Point(double coordinateX, double coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }

        //campo calcolato --> proprietà di sola lettura
        public int Quadrant
        {
            get
            {
                int position;

                if (CoordinateX > 0 && CoordinateY > 0)
                {
                    position = 1;
                }
                else if (CoordinateX < 0 && CoordinateY > 0)
                {
                    position = 2;
                }
                else if (CoordinateX < 0 && CoordinateY < 0)
                {
                    position = 3;
                }
                else if (CoordinateX > 0 && CoordinateY < 0)
                {
                    position = 4;
                }
                else
                {
                    throw new Exception("Il punto non è in nessun quadrante");
                }

                return position;
            }
        }

        public void translateX(double newX)
        {
            CoordinateX += newX;
        }
        public void translateY(double newY)
        {
            CoordinateY += newY;
        }

        //ridefinisco (override) il comportamento del metodo Equals  nel caso in cui gli oggetto da confrontare siano Point
        public override bool Equals(object? obj)
        {
            try
            {
                //trasformo obj in un punto
                Point p = (Point)obj;
                if (CoordinateX == p.CoordinateX && CoordinateY == p.CoordinateY)
                    return true;
                return false;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}

