using PuntoSegmentoCerchio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PianoCartesiano
{
    public class Drawer
    {
        public void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void WriteAxes(cartesianPlane c)
        {
            for (int i = 0; i < c.WindowsWidht; i++)
            {
                if (i == c.OrigCol)
                {
                    WriteAt("┼", c.OrigCol, c.OrigRow);
                }
                else
                {
                    WriteAt("─", i, c.OrigRow);
                }
            }
            for (int i = 0; i < c.WindowsHeight; i++)
            {
                if (i != c.OrigRow)
                {
                    WriteAt("│", c.OrigCol, i);
                }
            }
        }

        public void DrowingPoint(cartesianPlane c, Point p)
        {
            if (p.Quadrant() == 1)
            {
                WriteAt("■", c.OrigCol + p.X, c.OrigRow - p.Y);
            }
            else
            {
                if(p.Quadrant() == 2)
                {
                    WriteAt("■", c.OrigCol + p.X, c.OrigRow - p.Y);
                }
                else
                { 
                    if(p.Quadrant() == 3)
                    {
                        WriteAt("■", c.OrigCol + p.X, c.OrigRow - p.Y);
                    }
                    else
                    {
                        if(p.Quadrant() == 4)
                        {
                            WriteAt("■", c.OrigCol + p.X, c.OrigRow - p.Y);
                        }
                        else
                        {
                                WriteAt("■", c.OrigCol, c.OrigRow);
                        }
                    }    
                }
            }       
                        
        }

        public void DrowingSegment(cartesianPlane c, Segment s)
        {
            DrowingPoint(c, s.Start);
            DrowingPoint(c, s.End);

            if (s.Start.X == s.End.X)
            {
                Point temp = new Point(s.Start.X, s.Start.Y);
                while (temp.Y != s.End.Y)
                {
                    temp.Y++;
                    DrowingPoint(c, temp);
                }
            }
            else
            {
                if (s.Start.Y == s.End.Y)
                {
                    Point temp = new Point(s.Start.X, s.Start.Y);
                    while (temp.X != s.End.X)
                    {
                        temp.X++;
                        DrowingPoint(c, temp);
                    }
                }
                else
                {
                    double m = (double)(s.End.Y - s.Start.Y) / (s.End.X - s.Start.X);
                    double q = s.Start.Y - (m * s.Start.X);
                    for (Point temp = new Point(s.Start.X + 1, s.Start.Y); temp.X < s.End.X; temp.X++)
                    {
                        temp.Y = Convert.ToInt32((m * temp.X) + q);
                        DrowingPoint(c, temp);
                    }
                }
            }
        }       
    }
}
