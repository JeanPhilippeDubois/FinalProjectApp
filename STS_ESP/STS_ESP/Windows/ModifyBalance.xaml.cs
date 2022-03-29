using STS_ESP.ViewModels;
using System.Windows;

namespace STS_ESP.Windows
{
    /// <summary>
    /// Interaction logic for ModifyBalance.xaml
    /// </summary>
    public partial class ModifyBalance : Window
    {
        public ModifyBalance()
        {
            DataContext = new ModifyBalanceViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
