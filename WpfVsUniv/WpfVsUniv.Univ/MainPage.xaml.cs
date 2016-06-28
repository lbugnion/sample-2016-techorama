using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;

namespace WpfVsUniv.Univ
{
    public sealed partial class MainPage
    {
        public MainPage()
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
