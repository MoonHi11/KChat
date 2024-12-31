using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using KayTown.Modelss;
using Xamarin.Forms;

namespace KayTown.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public ICommand AddUserCommand { get; }

        public string UserNames { get; set; }
        public string Passwords { get; set; }
        public string Emails { get; set; }
        public int Phones { get; set; }
        public string ProfilePictures { get; set; }
        public string AboutYous { get; set; }
        public DateTime DateOfBirths { get; set; }
        public ICommand LoadUserCommand { get; }
        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
            AddUserCommand = new Command(AddUser);
            LoadUserCommand = new Command(LoadUser);
            LoadUser();
        }

        private void AddUser(object obj)
        {
            var newUser = new User
            {
                UserID = Guid.NewGuid().ToString(),
                UserName = UserNames,
                PhoneNumber = Phones,
                Email = Emails,
                ProfilePicture = ProfilePictures,
                LastSeen = DateTime.Now.ToString(),
                AboutYou = AboutYous,
                DateOfBirth = DateOfBirths,

            };
            App.DatabaseInit.AddUser(newUser);
            Users.Add(newUser);
        }

        private void LoadUser()
        {
            Users.Clear();
            var allUsers = App.DatabaseInit.GetAllUsers();
            foreach (var user in allUsers)
            {
                Users.Add(user);
            }
        }
    }
}
