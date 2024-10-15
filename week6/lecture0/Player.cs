namespace lecture0
{
    public class Player
    {
        public string Name { get; set; } // read/write
        public int Score { get; private set; } //read only
        private int _level; //backing fields
        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                // add checking code
                if (value >= 0)
                {
                    _level = value;
                }
            }
        }
        public int HighScore { get;
            private set; } //read only
        public int TotalScore {
            get
            {
                return this.Level * 100 + this.Score;

            }
        }

        public Player(string name, int score, int highScore)
        {
            Name = name;
            Score = score; 
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
