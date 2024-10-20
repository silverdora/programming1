using System;
namespace assignment4
{
	public class Drink
	{
		//fields
		public string Name;
		public double Price;
		public bool IsAlcoholic;
		string alco;

        //constructor
        public Drink(string name, double price, bool isAlcoholic)
		{
			this.Name = name;
			this.Price = price;
			this.IsAlcoholic = isAlcoholic;
		}

        //methods
        public string GetDescription()
		{
			if (IsAlcoholic)
			{
				alco = "Alcoholic";
			}
			else
			{
				alco = "Non-Alcoholic";

            }
			return $"{Name} - {Price:0.00} ({alco})";
		}
    }
}

