using STS_ESP.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace STS_ESP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class LoggingWindow : Window
    {
        public LoggingWindow()
        {
            DataContext = new LoggingWindowViewModel();
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).SecuredAccPass = ((PasswordBox)sender).SecurePassword; }
        }
    }



}
