using System.Windows;
using System.Windows.Controls;
using UserApp.ViewModel;
namespace UserApp.View
{
    public partial class CollectionView : UserControl
    {
        CollectionViewModel viewModel = new CollectionViewModel();
        public CollectionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Users.Add(new Model.User() { Name = txtUserName.Text});
            txtUserName.Text = string.Empty;
        }
    }
}
