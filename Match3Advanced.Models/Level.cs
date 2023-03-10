using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Level
    {
        public GameField GameField { get; set; }

        public List<Purpose> purposes { get; set; }

        public Level(GameField gameField, List<Purpose> purposes)
        {
            GameField = gameField;
            this.purposes = purposes;
        }
    }
}
