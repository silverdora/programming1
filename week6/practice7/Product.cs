using System;
namespace practice7
{
	public class Product
	{
		// properties
		public string Name { get; }
		public double Price { get; private set; }
		
		// consructor
		public Product(string name, double price)
		{
			this.Name = name;
			this.Price = price;
		}

        // methods
        public void DisplayProductInfo()
        {
            Console.WriteLine($"\nProduct Details:\n" +
				$"Name: {Name}\n" +
				$"Price: {Price}");
        }
    }
}

