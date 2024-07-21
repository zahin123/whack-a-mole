using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GNS.Games.WackAMole
{
    public class Player
    {
        private string name, difficulty;
        private int score;

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Player()
        {
            this.name = "";
            this.score = 0;
            this.difficulty = "";
        }

        public Player(string name)
            : this()
        {
            this.name = name;
        }

        public Player(string name, int score)
            : this(name)
        {
            this.score = 0;
        }

        public Player(string name, int score, string difficulty)
            : this(name, score)
        {
            this.difficulty = difficulty;
        }
    }
}
