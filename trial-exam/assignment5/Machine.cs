using System;
namespace assignment5
{
    public class Machine
    {
        //fields
        private int _numberOfWorkingHours; //backing field
        //properties
        public string Name { get; private set; } //read-only

        private string needOfMaintance;

        public int NumberOfWorkingHours
        {
            get
            { return _numberOfWorkingHours; }
            set
            {
                if (value >= 0)

                {
                    _numberOfWorkingHours = value;
                }
            }
        }

        public bool NeedsMaintenance
        {
            get
            {
                return (NumberOfWorkingHours >= 10000);
            }
        }

        //constructor
        public Machine(string name, int numberOfWorkingHours)
        {
            Name = name;
            NumberOfWorkingHours = numberOfWorkingHours;
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

