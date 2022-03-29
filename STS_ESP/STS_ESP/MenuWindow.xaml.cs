using STS_ESP.ViewModels;
using System.Windows;

namespace STS_ESP
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {

            DataContext = new MenuViewModel();
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            ButtonClose.Visibility = Visibility.Hidden;
            ButtonOpen.Visibility = Visibility.Visible;
            Logo.Visibility = Visibility.Hidden;
            GestionCompteText.Visibility = Visibility.Hidden;
            GestionText.Visibility = Visibility.Hidden;
            RapportText.Visibility = Visibility.Hidden;
            UsagerText.Visibility = Visibility.Hidden;
            DecoText.Visibility = Visibility.Hidden;
            MenuLeft.Width = new GridLength(50);
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            ButtonClose.Visibility = Visibility.Visible;
            ButtonOpen.Visibility = Visibility.Hidden;
            Logo.Visibility = Visibility.Visible;
            GestionCompteText.Visibility = Visibility.Visible;
            GestionText.Visibility = Visibility.Visible;
            RapportText.Visibility = Visibility.Visible;
            UsagerText.Visibility = Visibility.Visible;
            DecoText.Visibility = Visibility.Visible;
            MenuLeft.Width = new GridLength(275);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
