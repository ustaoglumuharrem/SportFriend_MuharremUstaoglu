using SportFriend.Data;
using SportFriend.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SportFriend
{
    /// <summary>
    /// Interaction logic for SignUpWindow.xaml
    /// </summary>
    public partial class SignUpWindow : Window
    {
        public SignUpWindow(FriendUser friendUser)
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            SportUserService sportUserService = new SportUserService();

            FriendUser friendUser = new FriendUser();

            friendUser.Name = txtName.Text;
            friendUser.Surname = txtSurname.Text;
            friendUser.UserName = txtUserName.Text;
            friendUser.RoleId = 2;

            string firstpassword = sportUserService.hashPassword(txtpassword1.Password.ToString());
            string secondpassword = sportUserService.hashPassword(txtpassword2.Password.ToString());
            if (firstpassword == secondpassword) {

                friendUser.Password = firstpassword;

            }
            friendUser.BirthDate = datebirth.SelectedDate.Value;

            SportFriendDb database = new SportFriendDb();
            database.FriendUser.Add(friendUser);
            database.SaveChanges();
            MessageBox.Show("User created.");


            txtName.Text = "";
            txtSurname.Text = "";
            txtUserName.Text = "";
            txtpassword1.Password = "";
            txtpassword2.Password = "";
            datebirth.SelectedDate = DateTime.Now;






        }
    }
}
