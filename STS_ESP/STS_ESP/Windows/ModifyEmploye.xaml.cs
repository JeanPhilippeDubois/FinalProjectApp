using STS_ESP.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace STS_ESP.Windows
{
    /// <summary>
    /// Interaction logic for ModifyEmploye.xaml
    /// </summary>
    public partial class ModifyEmploye : Window
    {
        public ModifyEmploye()
        {
            DataContext = new ModifyEmployeViewModel();
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).SecuredAccPass = ((PasswordBox)sender).SecurePassword; }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
