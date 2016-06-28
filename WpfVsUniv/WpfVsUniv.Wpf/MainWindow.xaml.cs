using System.Windows;
using System.Windows.Media.Animation;

namespace WpfVsUniv.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClick(object sender, RoutedEventArgs e)
        {
            var sbd = (Storyboard)Resources["BallStoryboard"];
            sbd.Begin();
        }
    }
}
