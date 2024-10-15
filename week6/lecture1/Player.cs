using System;
namespace lecture1
{
	public class Player
	{
		private string Name;
		private int Score;
		private int HighScore;

		public Player(string name, int score, int highScore)
		{
			Name = name;
			Score = score;
			HighScore = highScore;
		}

		public void AddScore(int additionalScore)
		{
			if (additionalScore < 0)
			{
				return;
			}
			Score += additionalScore;
			UpdateHighScore();
		}

		public int GetScore()
		{
			return Score;
		}

		private void UpdateHighScore()
		{
			if (Score > HighScore)
			{
				HighScore = Score;
			}
		}

		
	}
}

