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
        public int CurrentLevelNumber = 1;

        public MenuWindow()
        {
            InitializeComponent();
        }

        public void Update()
        {

        }
    }
}
