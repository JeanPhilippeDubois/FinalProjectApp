using STS_ESP.ViewModels;
using System.Windows.Controls;

namespace STS_ESP.Pages
{
    /// <summary>
    /// Interaction logic for UsersList.xaml
    /// </summary>
    public partial class UsersList : Page
    {
        public UsersList()
        {
            DataContext = new UsersListViewModel();
            InitializeComponent();
        }
    }
}
