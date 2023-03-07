using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match3Advanced.Models
{
    public class GameField
    {
        private Cell[,] cells;
        public int width { get; }
        public int heigth { get; }

        public GameField(Cell[,] cells)
        {
            this.cells = cells;
        }

        public GameField(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
            cells = new Cell[width, heigth];
            for (var x=0; x<width; x++)
            {
                for (var y=0; y < heigth; y++) 
                {
                    cells[x, y] = new Cell(null, null);
                }
            }
        }

        public void SetOnField(Point point,IOnField onField)
        {
            cells[point.X, point.Y] = new Cell(onField, null);
        }

        public void DeleteOnField(Point point)
        {
            cells[point.X, point.Y] = new Cell(null, null);
        }
    }
}