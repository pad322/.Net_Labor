using EmployeeApp.ViewModel;
using System.Windows;
namespace EmployeeApp
{
    public partial class MainWindow : Window
    {
        EmployeeViewModel employeeViewModel;
        public MainWindow()
        {
            InitializeComponent();
            employeeViewModel = new EmployeeViewModel();
            DataContext = employeeViewModel;
        }
    }
}