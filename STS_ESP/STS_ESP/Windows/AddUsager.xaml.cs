using STS_ESP.ViewModels;
using System.Windows;

namespace STS_ESP.Windows
{
    /// <summary>
    /// Interaction logic for AddUsager.xaml
    /// </summary>
    public partial class AddUsager : Window
    {
        public AddUsager()
        {
            DataContext = new AddUsagerViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
