using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PianoCartesiano
{
    public class Circle
    {
        private Point _centre;
        private double _radius;

        public Point Centre
        {
            get{ return _centre; }
        }

        public double Radius
        {
            get{return _radius; }
        }
        public Circle(Point centre, double radius)
        {
            _centre = centre;
            _radius = radius;
        }
        public double CalculateCircumference()
        {
            return _radius * 2 * Math.PI;
        }
        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
    }
}

