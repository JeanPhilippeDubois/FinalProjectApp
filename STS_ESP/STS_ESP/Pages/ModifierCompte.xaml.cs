using STS_ESP.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace STS_ESP.Pages
{
    /// <summary>
    /// Interaction logic for ModifierCompte.xaml
    /// </summary>
    public partial class ModifierCompte : Page
    {
        public ModifierCompte()
        {
            DataContext = new ModifierCompteViewModel();
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).SecuredAccPass = ((PasswordBox)sender).SecurePassword; }
        }
    }
}
