using STS_ESP.ViewModels;
using System.Windows.Controls;

namespace STS_ESP.Pages
{
    /// <summary>
    /// Interaction logic for SellTickets.xaml
    /// </summary>
    public partial class SellTickets : Page
    {
        public SellTickets()
        {
            DataContext = new SellTicketsViewModel();
            InitializeComponent();
        }
    }
}
