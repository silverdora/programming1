using System;
namespace practice3
{
	public class Calculator
	{
		//fields
		public int[] numbers = new int[3];

        //methods
        public static int CalculateSum(int[] numbers)
		{
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}
			return sum;
		}


        public static double CalculateAverage(int[] numbers)
		{
            int sum = CalculateSum(numbers);
			return (double)sum / numbers.Length;
        }
	}
}

