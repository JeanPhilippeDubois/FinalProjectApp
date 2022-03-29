using STS_ESP.ViewModels;
using System.Windows;

namespace STS_ESP.Windows
{
    /// <summary>
    /// Interaction logic for ModifyAbonnement.xaml
    /// </summary>
    public partial class ModifyAbonnement : Window
    {
        public ModifyAbonnement()
        {
            DataContext = new ModifyAbonnementViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
