using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Program
    {

        interface IPrint
        {
            void Print();
        }
        abstract class Figure
        {
            public string Type
            {
                get
                {
                    return this._Type;
                }
                protected set
                {
                    this._Type = value;
                }
            }
            string _Type;
            public abstract double Area();
        }
        class Rectangle : Figure, IPrint
        {
            double a, b;
            public Rectangle(double a, double b)
            {
                this.a = a;
                this.b = b;
                this.Type = "Rectangle";
            }
            public Rectangle(double a)
            {
                this.a = a;
                this.b = b;
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Length equals: " + a + "\n" + "Width equals: " + b + "\n" + "Area equals: " + Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return a * b;
            }
        }
        class Square : Rectangle, IPrint
        {
            double a;
            public Square(double a) : base(a)
            {
                this.a = a;
                this.Type = "Square";
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Length and width equals: " + a + "\n" + "Area equals: " + Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return a * a;
            }
        }
        class Circle : Figure, IPrint
        {
            double a;
            public Circle(double a)
            {
                this.a = a;
                this.Type = "Circle";
            }
            public override string ToString()
            {
                return this.Type + "\n" + "Radius equals: " + a + "\n" + "Area equals: " +
                    Area();
            }
            public void Print()
            {
                Console.WriteLine(ToString());
            }
            public override double Area()
            {
                return 3.14 * a * a;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Area of what figure do you want to calculate");
            Console.WriteLine("Press 1 === Circle");
            Console.WriteLine("Press 2 === Rectangle");
            Console.WriteLine("Press 3 === Square");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Write the radius of your circle:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Circle circle = new Circle(a);
                    circle.Print();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Write the length of your rectangle:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write the width of your rectangle:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(b, c);
                    rectangle.Print();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Write the length of one side of your square:");
                    int d = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(d);
                    square.Print();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ooops! Wrong key sorry:)");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
