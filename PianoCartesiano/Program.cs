using PuntoSegmentoCerchio;
using System;
namespace PianoCartesiano
{

    internal class Program
    {
        static void Main(string[] args)
        {
            cartesianPlane c = new cartesianPlane(201, 51, 101, 26);
            //Console.SetWindowSize(c.WindowsWidht, c.WindowsHeight);

            Point p = new Point(2,2);
            p.DrowingPoint(c);
            
            p.translateX(1);
            Console.Clear();
            p.DrowingPoint(c);
            
            p.translateY(1);
            Console.Clear();
            p.DrowingPoint(c);


            Point pA = new Point(20,12);
            Point pB = new Point(12,6);
            Segment s = new Segment(pA,pB);
            Console.Clear();
            s.DrowingSegment(c);
            //pA.DrowingPoint(c);
            //pB.DrowingPoint(c);



            Point a1 = new Point(2,3);
            Point a2 = new Point(25,3);
            Segment s1 = new Segment(a1,a2);
            s1.DrowingSegment(c);

            Point b1 = new Point(1,6);
            Point b2 = new Point(1,22);
            Segment s2 = new Segment(b1,b2);
            s2.DrowingSegment(c);

            c.WriteAxes();

        }
    }
}