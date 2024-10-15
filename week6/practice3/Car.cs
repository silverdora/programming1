using System;
namespace practice3
{
	public class Car
	{
		// fields
		private string _make;
		private string _model;
		private int _year;

        // properties
        public string Make
        {
            get { return _make; }

            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }

            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }

            set { _year = value; }
        }

        // constructor
        public Car(string make, string model, int year)
		{
            this.Make = make;
            this.Model = model;
            this.Year = year;
		}

        // methods
        public void DisplayCarInfo()
        {
            Console.WriteLine($"\nCar Details:\n" +
                $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}");
        }
    }
}

