using System;
namespace practice6
{
	public class VotingSystem
	{
		// fields
		private VoteOption[] options;
		public int alreadyVoted = 0;
		public int yes = 0;
		public int no = 0;

		// constructor
		public VotingSystem(int size)
		{
			this.options = new VoteOption[size];
		}

		//methods
		public void CastVote(VoteOption vote)
		{
			options[alreadyVoted] = vote;
			alreadyVoted += 1;
			if (vote == VoteOption.Yes)
			{
				yes++;
			}
			else
			{
				no++;
			}
		}
		public void DisplayResults()
		{
			Console.WriteLine($"Results:\nYes: {yes}\nNo: {no}");
		}


    }
}

