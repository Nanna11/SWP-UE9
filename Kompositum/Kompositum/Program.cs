using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompositum
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicObject c = new Circle(1, 5);
            Console.WriteLine(c.ObjectType + " created at " + c.Coordinates);

            GraphicObject r = new Rectangle(-5, 8);
            Console.WriteLine(r.ObjectType + " created at " + r.Coordinates);

            GraphicObject t = new Triangle(7, -3);
            Console.WriteLine(t.ObjectType + " created at " + t.Coordinates);

            Console.WriteLine();

            t.move(-7, 3);
            Console.WriteLine(t.ObjectType + " moved to" + t.Coordinates);

            Console.WriteLine();

            GraphicObject g1 = new GraphicObjectGroup();

            g1.Add(r);
            Console.WriteLine(r.ObjectType + " added to ObjectGroup1");
            Console.WriteLine("ObjectGroup1 now located at " + g1.Coordinates);

            Console.WriteLine();

            g1.Add(c);
            Console.WriteLine(c.ObjectType + " added to ObjectGroup1");
            Console.WriteLine("ObjectGroup1 now located at " + g1.Coordinates);

            Console.WriteLine();

            g1.move(1, 1);
            Console.WriteLine("ObjectGroup1 moved to" + g1.Coordinates);
            Console.WriteLine(c.ObjectType + " now located at " + c.Coordinates);
            Console.WriteLine(r.ObjectType + " now located at " + r.Coordinates);

            Console.WriteLine();

            GraphicObject g2 = new GraphicObjectGroup();

            g2.Add(t);
            Console.WriteLine(t.ObjectType + " added to ObjectGroup2");
            Console.WriteLine("ObjectGroup2 now located at " + g2.Coordinates);

            Console.WriteLine();

            g2.Add(g1);
            Console.WriteLine("ObjectGroup1 added to ObjectGroup2");
            Console.WriteLine("ObjectGroup2 now located at " + g2.Coordinates);

            Console.WriteLine();

            g2.move(1, 1);
            Console.WriteLine("ObjectGroup2 moved to" + g2.Coordinates);
            Console.WriteLine("ObjectGroup1 now located at " + g1.Coordinates);
            Console.WriteLine(c.ObjectType + " now located at " + c.Coordinates);
            Console.WriteLine(r.ObjectType + " now located at " + r.Coordinates);
            Console.WriteLine(t.ObjectType + " now located at " + t.Coordinates);

            Console.ReadKey();
        }
    }
}
