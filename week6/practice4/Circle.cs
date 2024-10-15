using System;
namespace practice4
{
	public class Circle
	{
		// fields
		private double _radius;

        // properties
        public double Radius
        {
            get { return _radius; }

            set { _radius = value; }
        }

		public double Area
		{
            get { return CalculateArea(_radius); }
        }

        //constructor
        public Circle(double radius)
		{
			this.Radius = radius;
		}

		// methods
		private double CalculateArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2);
		}

        public void DisplayInfo()
		{
			Console.WriteLine($"\nRadius: {Radius}");
            Console.WriteLine($"Area: {Area:0.00}");
        }

    }
}

