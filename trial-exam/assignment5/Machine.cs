using System;
namespace assignment5
{
	public class Machine
	{
        //fields
        private int _numberOfWorkingHours;
        //properties
        public string Name { get; }
		
		private string needOfMaintance;

        public int NumberOfWorkingHours
		{
			get
			{ return _numberOfWorkingHours; }
			set
			{
				if (_numberOfWorkingHours > 0)

				{
					_numberOfWorkingHours = value;
				}
            }
		}

		public bool NeedsMaintenance
		{
			get
			{
				if (NumberOfWorkingHours >= 10000)
					return true;
				else
					return false;
			}
		}

        //constructor
        public Machine(string name, int numberOfWorkingHours)
		{
			this.Name = name;
			this._numberOfWorkingHours = numberOfWorkingHours;
		}

		//methods
        public void DisplayInfo()
		{
			if (NeedsMaintenance)
				needOfMaintance = "yes";
			else
				needOfMaintance = "no";
			Console.WriteLine($"\nMachine name: {Name}\n" +
				$"Number of working hours: {NumberOfWorkingHours}\n" +
				$"Needs maintainance: {needOfMaintance}");
		}
    }
}

