using Match3Advanced.LevelStorage;
using Match3Advanced.Models;
using Match3Advanced.ProgressStorage;
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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public Progress Progress = new Progress(DateTime.UtcNow,5,new bool[1001]);
        public IProgressStorage progressStorage = new TempProgressStorage();
        public ILevelStorage levelStorage = new TempLevelStorage();
        public int CurrentLevelNumber = 1;

        public MenuWindow()
        {
            InitializeComponent();
            Update();
        }

        public void _play(object sender, EventArgs e)
        {
            Window window = new LevelWindow(levelStorage.Load(CurrentLevelNumber),Progress, CurrentLevelNumber);
            window.Show();
        }

        public void _previous(object sender, EventArgs e)
        {
            CurrentLevelNumber--;
            if (CurrentLevelNumber < 1)
            {
                CurrentLevelNumber = 1000;
            }
            Update();
        }

        public void _next(object sender, EventArgs e)
        {
            CurrentLevelNumber++;
            if (CurrentLevelNumber > 1000)
            {
                CurrentLevelNumber = 1;
            }
            Update();
        }

        public void _save(object sender, EventArgs e)
        {
            progressStorage.Save(new Progress(DateTime.UtcNow, Progress.Lifes, Progress.GetResults()));
        }

        public void Update()
        {
            Progress = progressStorage.Load();
            _lifesProgress.Value = Progress.Lifes;
            _levelNumber.Text = "Уровень номер " + CurrentLevelNumber;
        }

    }
}
