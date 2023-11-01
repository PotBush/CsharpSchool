﻿using PianoCartesiano;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PuntoSegmentoCerchio
{
    public class Segment
    {
        private Point _pointStart;
        private Point _pointEnd;

        public Point 
        public Segment(Point point1, Point point2)
        {

            if (point1.Equals(point2) == false)
            {
                if(point1.X < point2.X || (point1.X == point2.X && point1.Y < point2.Y))
                {
                    _pointStart = point1;
                    _pointEnd = point2;
                }
                else
                {
                    _pointStart = point2;
                    _pointEnd = point1;                      
                }
                
            }
            else
            {
                throw new ArgumentException("gli estremi non possono coincidere");
            }
        }

        public double CalculateLength()
        {
            double diffX = _pointEnd.X - _pointStart.X;
            double diffY = _pointEnd.Y - _pointStart.Y;

            return Math.Sqrt((diffX * diffX) + (diffY * diffY));
        }

        public bool checksPuntBelongsSegment(Point pointC)
        {
            int Xc = pointC.X;
            int Yc = pointC.Y;
            int Xa = _pointStart.X;
            int Ya = _pointStart.Y;
            int Xb = _pointEnd.X;
            int Yb = _pointEnd.Y;

            bool temp = false;

            if ((Xc - Xa) * (Yb - Ya) - (Yc - Ya) * (Xb - Xa) == 0) // se pointC si trova sullaretta y=m-q+c -> di equazione (x - xa)(yb - ya) - (y - ya)(xb - xa) = 0
            {
                if (Xa == Xb && Xb == Xc)
                {
                    if (Ya > Yb)
                    {
                        if (Yc < Ya && Yc > Yb)
                        {
                            temp = true;
                        }

                    }
                    else
                    {
                        if (Ya < Yb)
                        {
                            if (Yc > Ya && Yc < Yb)
                            {
                                temp = true;
                            }
                        }
                    }
                }

                if (Xa < Xb)
                {
                    if (Xc > Xa && Xc < Xb)
                    {
                        temp = true;
                    }
                }
                else
                {
                    if (Xa > Xb)
                    {
                        if (Xc < Xa && Xc > Xb)
                        {
                            temp = true;
                        }
                    }
                }
            }

            return temp;
        }


        public override bool Equals(object? obj)
        {
            Segment s = (Segment)obj;
            if (_pointStart.Equals(s._pointStart) && _pointEnd.Equals(s._pointEnd))
                return true;
            return false;

        }

        public override string ToString()
        {
            return $"({_pointStart.ToString()})({_pointEnd.ToString()};)";
        }

        
    }
}




