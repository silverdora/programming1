namespace practice6;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Start();
    }

    void Start()
    {
        // get the number of votes
        Console.Write("How many votes should be processed: ");
        int size = int.Parse(Console.ReadLine());

        // get the votes
        VotingSystem votes = new VotingSystem(size);

        for (int i = 0; i < size; i++)
        {
            // enter a vote
            Console.Write("Enter your vote (Yes/No): ");
            string input = Console.ReadLine();

            //convert to an enum value
            VoteOption vote = (VoteOption)Enum.Parse(typeof(VoteOption), input);

            //cast vote
            votes.CastVote(vote);
            Console.WriteLine($"Vote casted: {vote}\n");
        }

        // display results
        votes.DisplayResults();

    }
}
