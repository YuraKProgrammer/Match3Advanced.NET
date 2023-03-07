using Match3Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.ProgressStorage
{
    public interface IProgressStorage
    {
        public void Save(Progress progress);
        public Progress Load();
        public List<Progress> LoadAll();
    }
}
