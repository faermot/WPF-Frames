using System.Windows;
using WpfApp21.Services;
using WpfApp21.View;

namespace WpfApp21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ServiceNavigateHelper.FrameNavigate = MainWindowFrame;

            MainWindowFrame.Navigate(new Task1Page());
        }
    }
}
