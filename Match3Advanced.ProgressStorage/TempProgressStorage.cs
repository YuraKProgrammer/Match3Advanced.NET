using Match3Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.ProgressStorage
{
    public class TempProgressStorage : IProgressStorage
    {
        public Progress Load()
        {
            throw new NotImplementedException();
        }

        public List<Progress> LoadAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Progress progress)
        {
            throw new NotImplementedException();
        }
    }
}
