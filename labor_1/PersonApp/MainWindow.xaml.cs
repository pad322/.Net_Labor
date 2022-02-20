using System.Collections.Generic;
using System.Windows;

namespace PersonApp
{
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Person { FirstName = "John", LastName = "Doe" });
            people.Add(new Person { FirstName = "Joe", LastName = "Smith" });
            people.Add(new Person { FirstName = "Sue", LastName = "Strom" });
            cmbBxPeopleName.ItemsSource = people;
        }
        private void bttnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {txtBxFirstName.Text} {txtBxLastName.Text}");
        }
    }
}