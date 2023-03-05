using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models.Generators
{
    public class FieldGenerator : IFieldGenerator
    {
        private IChipGenerator ChipGenerator = new ChipGenerator();
        public GameField GenerateField(GameField gameField)
        {
            for (var x=0; x < gameField.width; x++)
            {
                for (var y=0; y < gameField.heigth; y++)
                {
                    gameField.SetOnField(new Point(x, y), ChipGenerator.GenerateChip());
                }
            }
            return gameField;
        }
    }
}
