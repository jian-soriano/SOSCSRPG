using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// allows MainWindow.xaml.cs to use GameSession objects
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;

        public MainWindow()
        {
            // draws the screen and other objects (grids, labels, etc.)
            InitializeComponent();

            _gameSession = new GameSession();

            // allows MainWindow.xaml to access _gameSession values
            DataContext = _gameSession;
        }
        // adds 10 to CurrentPlayer's ExperiencePoints property
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints = _gameSession.CurrentPlayer.ExperiencePoints + 10;
        }
    }
}