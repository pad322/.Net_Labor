using System.Collections.ObjectModel;
using UserApp.Model;
namespace UserApp.ViewModel
{
    public class CollectionViewModel
    {
        //public List<User> Users { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public CollectionViewModel()
        {
            Users = new ObservableCollection<User>();
            Users.Add(new User() { Name = "Administrator" , Age = "27"});
            Users.Add(new User() { Name = "root" , Age = "12"});
            Users.Add(new User() { Name = "Blackhawk", Age = "62"});
            Users.Add(new User() { Name = "User001", Age = "18"});
            Users.Add(new User() { Name = "Cortana", Age = "2"});
        }
    }
}