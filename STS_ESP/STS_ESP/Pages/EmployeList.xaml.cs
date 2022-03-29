using STS_ESP.ViewModels;
using System.Windows.Controls;

namespace STS_ESP.Pages
{
    /// <summary>
    /// Interaction logic for EmployeList.xaml
    /// </summary>
    public partial class EmployeList : Page
    {
        public EmployeList()
        {
            DataContext = new EmployeListViewModel();
            InitializeComponent();
        }
    }
}
