using STS_ESP.ViewModels;
using System.Windows;

namespace STS_ESP.Windows
{
    /// <summary>
    /// Interaction logic for ModifyUsager.xaml
    /// </summary>
    public partial class ModifyUsager : Window
    {
        public ModifyUsager()
        {
            DataContext = new ModifierUsagerViewModel();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
