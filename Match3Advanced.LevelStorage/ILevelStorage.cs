using Match3Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.LevelStorage
{
    public interface ILevelStorage
    {
        public void Save(Level level);
        public Level Load(int number);
        public List<Level> LoadAll();
    }
}
