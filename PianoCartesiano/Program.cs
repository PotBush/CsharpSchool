using PuntoSegmentoCerchio;
using System;
namespace PianoCartesiano
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(-1, -1);
            Point b = new Point(8, 6);
            Segment s = new Segment(a, b);
            Console.Clear();

            cartesianPlane c = new cartesianPlane(201, 51, 101, 26);


            Console.SetWindowSize(c.WindowsWidht, c.WindowsHeight);

            //s.DrowingSegment(c);

            
            a.DrowingPoint(c);
            c.WriteAxes();







        }
    }
}