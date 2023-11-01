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
                        if (p.Quadrant() == 3)
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
                        
        }


            
        
        public void DrowingSegment(cartesianPlane c, Segment s)
        {
            DrowingPoint(c, s.Start);
            DrowingPoint(c, s.End);

            Point temp = s.Start;
            while(temp == s.End)
            {
                temp.translateX(1);
                temp.translateY(1);
                DrowingPoint(c, temp);
            }
        }
    }
}
