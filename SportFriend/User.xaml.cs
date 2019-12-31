using SportFriend.Data;
using SportFriend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SportFriend
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {
        private SportFriendDb Database = new SportFriendDb();
        private FriendUser loginUser;
        public User(FriendUser friendUser) 
        {
            loginUser = friendUser;
            InitializeComponent();
        }

        private void PasswordChange_Click(object sender, RoutedEventArgs e)
        {

            ChangePasswordWindow changePasswordWindow = new ChangePasswordWindow(loginUser);
            changePasswordWindow.Show();
            

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Yes", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
         {
                
               
                this.Close();
            }
        }

        private void CreateDemand_Click(object sender, RoutedEventArgs e)
        {
            CreateDemandWindow createDemandWindow = new CreateDemandWindow(loginUser);
            createDemandWindow.Show();
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {

            if (loginUser.RoleId == 1) { 
                EventWindow eventWindow = new EventWindow(loginUser);
                eventWindow.Show();
            }
            else
            {
                MessageBox.Show("Only Admin can create Events!");
            }

        }

        private void CreatedEvents_Click(object sender, RoutedEventArgs e)
        {
            CreatedEventWindow createdEventWindow = new CreatedEventWindow(loginUser);
            createdEventWindow.Show();
        }

    

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            txtDisplay.Text = "Merhaba, " + loginUser.Name + " " + loginUser.Surname + "," +
                " " +  Database.UserRoles.Where(u => u.Id==loginUser.RoleId).First().RoleContent;



        }
    }
}
