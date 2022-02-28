using System.Windows;
using UserApp.ViewModel;
namespace UserApp
{
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ChangeName(txtNewName.Text);
        }
    }
}