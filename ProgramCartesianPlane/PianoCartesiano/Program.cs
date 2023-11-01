using PuntoSegmentoCerchio;
using System;
namespace PianoCartesiano
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Drawer d = new Drawer();
            cartesianPlane c = new cartesianPlane(201, 51, 101, 26);
            //Console.SetWindowSize(c.WindowsWidht, c.WindowsHeight);

/*
            Point p = new Point(2,2);
            d.DrowingPoint(c,p);
            
            p.translateX(1);
            Console.Clear();
            d.DrowingPoint(c,p);
            
            p.translateY(1);
            Console.Clear();
            d.DrowingPoint(c,p);


            Point pA = new Point(20,12);
            Point pB = new Point(12,6);
            Segment s = new Segment(pA,pB);
            Console.Clear();
            d.DrowingSegment(c,s);
            //pA.DrowingPoint(c);
            //pB.DrowingPoint(c);



            Point a1 = new Point(2,3);
            Point a2 = new Point(25,3);
            Segment s1 = new Segment(a1,a2);
            d.DrowingSegment(c,s1);

            Point b1 = new Point(1,6);
            Point b2 = new Point(1,22);
            Segment s2 = new Segment(b1,b2);
            d.DrowingSegment(c,s2);
*/

            Point pA = new Point(3,3);
            Point pB = new Point(6,6);
            Segment s = new Segment(pA,pB);
            Console.Clear();
            d.DrowingSegment(c,s);

            d.WriteAxes(c);

        }
    }
}