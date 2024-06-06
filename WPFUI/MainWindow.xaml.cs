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
        // FIELDS
        private GameSession _gameSession;

        // CONSTRUCTOR
        public MainWindow()
        {
            // draws the screen and other objects (grids, labels, etc.)
            InitializeComponent();

            _gameSession = new GameSession();

            // allows MainWindow.xaml to access _gameSession values
            DataContext = _gameSession;
        }
        
        // METHODS

        // private because it's only used by the MainWindow
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e) 
        {
            _gameSession.MoveNorth();
        }

        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }

        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }

        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
    }
}