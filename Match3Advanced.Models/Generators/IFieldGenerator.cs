using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models.Generators
{
    public interface IFieldGenerator
    {
        public GameField GenerateField(GameField gameField);
    }
}
