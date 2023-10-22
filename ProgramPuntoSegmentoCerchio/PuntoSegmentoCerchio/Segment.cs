using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoSegmentoCerchio
{
    public class Segment
    {
        private Point _point1;
        private Point _point2;

        public Segment(Point point1, Point point2)
        {

            if (point1.Equals(point2) == false)
            {
                _point1 = point1;
                _point2 = point2;
            }
            else
            {
                throw new ArgumentException("gli estremi non possono coincidere");
            }
        }

        public double CalculateLength()
        {
            double diffX = _point2.CoordinateX - _point1.CoordinateX;
            double diffY = _point2.CoordinateY - _point1.CoordinateY);

            return Math.Sqrt((diffX * diffX) + (diffY * diffY));
        }

        public double checksPuntBelongsSegment (Point)
    }
}




