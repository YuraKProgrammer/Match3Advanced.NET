using Match3Advanced.Models;
using Match3Advanced.Models.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.LevelStorage
{
    public class TempLevelStorage : ILevelStorage
    {
        public Level Load(int number)
        {
            IFieldGenerator fieldGenerator = new FieldGenerator();
            var gameField = fieldGenerator.GenerateField(new GameField(12,9));
            return new Level(gameField, new List<Purpose>());
        }

        public List<Level> LoadAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Level level)
        {
            throw new NotImplementedException();
        }
    }
}
