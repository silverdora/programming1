using System;
namespace practice1
{
	public class Rectangle
	{
		//fields
		public double Width, Height;

		//methods
		public double CalculateArea(double width, double height)
		{
			return width * height;
		}

        public double CalculatePerimeter(double width, double height)
		{
			return (width + height) * 2;
		}
	}
}

