using Match3Advanced.Models.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class Game
    {
        public IFieldGenerator fieldGenerator = new FieldGenerator();
        public GameField GameField { get; set; }

        public Level Level { get; set; }

        public void GenerateField()
        {
            GameField = fieldGenerator.GenerateField(GameField);
        } 
    }
}
