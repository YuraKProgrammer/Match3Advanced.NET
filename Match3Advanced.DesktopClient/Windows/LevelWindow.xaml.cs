using Match3Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Match3Advanced.DesktopClient.Windows
{
    /// <summary>
    /// Interaction logic for LevelWindow.xaml
    /// </summary>
    public partial class LevelWindow : Window
    {
        public Game Game;
        public Progress Progress;
        public int LevelNumber;
        public const int CellSize = 100;
        public LevelWindow(Level level, Progress progress, int levelNumber)
        {
            InitializeComponent();
            Game = new Game(level);
            Progress = progress;
            LevelNumber = levelNumber;
            DrawGameField();
        }

        #region Draw
        public void DrawGameField()
        {
            for (var x = 0; x < Game.GameField.width; x++)
            {
                for (var y = 0; y < Game.GameField.heigth; y++)
                {
                    DrawCell(new Models.Point(x,y));
                }
            }
        }

        public void DrawCell(Models.Point point)
        {
            var bitmapImage = new BitmapImage();
            var cl = Game.GameField.GetCell(point);
            if (CellVoidChecker.CheckCellIsEmpty(cl))
            {
                bitmapImage = new BitmapImage(new Uri(@"/Match3Advanced.DesktopClient;component/images/empty.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                bitmapImage = new BitmapImage(new Uri(cl.OnField.FileName, UriKind.RelativeOrAbsolute));
            }
            System.Windows.Controls.Image image = new System.Windows.Controls.Image();
            image.Width = CellSize;
            image.Height = CellSize;
            image.Source = bitmapImage;
            Canvas.SetLeft(image, CellSize * point.X);
            Canvas.SetTop(image, CellSize * point.Y);
            _gameField.Children.Add(image);
        }
        #endregion
    }
}
