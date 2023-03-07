using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Progress
    {
        public DateTime DateTime { get; set; }

        public int Lifes { get; set; }

        private bool[] LevelResults = new bool[1001];

        public void SetValue(int levelNumber, bool result)
        {
            LevelResults[levelNumber + 1] = result;
        }

        public Progress(DateTime dateTime, int lifes, bool[] levelResults)
        {
            DateTime = dateTime;
            if (lifes < 0)
            {
                Lifes = 0;
            }
            else if (lifes > 5)
            {
                Lifes = 5;
            }
            else
            {
                Lifes = lifes;
            }
            LevelResults = levelResults;
        }
    }
}
