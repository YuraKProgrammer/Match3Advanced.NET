using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public static class CellVoidChecker
    {
        public static bool CheckCellIsEmpty(Cell cell)
        {
            if (cell.OnField == null && cell.OnCell == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
