using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementation
{
    abstract class Figures
    {
        public double width, height, radius;
        public const float PI = 3.14f;

        public abstract void GetArea();
    }

    class Rectangle : Figures
    {
        public override void GetArea()
        {
            Console.WriteLine(height*width);
        }
        public Rectangle(double w, double h)
        {
            this.height = h;
            this.width = w;
        }
    }

    class Circle : Figures
    {
        public override void GetArea()
        {
            Console.WriteLine(PI*radius*radius);
        }
        public Circle(double r)
        {
            this.radius = r;            
        }
    }

    class Triangle : Figures
    {
        public override void GetArea()
        {
            Console.WriteLine(0.5f*height*width);
        }
        public Triangle(double w, double h)
        {
            this.height = h;
            this.width = w;
        }
    }

    class TestFigures
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            Circle c = new Circle(10);
            Triangle t = new Triangle(10, 20);            
            r.GetArea(); c.GetArea();t.GetArea();

            Console.ReadKey();
        }
    }
}
