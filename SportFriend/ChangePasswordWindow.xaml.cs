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
    /// Interaction logic for ChangePasswordWindow.xaml
    /// </summary>
    public partial class ChangePasswordWindow : Window
    {

        private FriendUser loginUser;
        private SportFriendDb Database = new SportFriendDb();

        public ChangePasswordWindow(FriendUser friendUser)
        {
            loginUser = friendUser;
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            SportUserService sportUserService = new SportUserService();
            string oldsifre = sportUserService.hashPassword(txtold.Password.ToString());

            if (oldsifre == loginUser.Password.ToString())
            {
                string newpassword = sportUserService.hashPassword(txtnew2.Password.ToString());
                string newpassword2 = sportUserService.hashPassword(txtnew1.Password.ToString());
                if (newpassword == newpassword2)
                {
                    loginUser.Password = newpassword;
                    Database.FriendUser.Update(loginUser);
                    Database.SaveChangesAsync();
                    MessageBox.Show("Password is changed.");

                }
                else MessageBox.Show("Wrong attempt");




            }
            else MessageBox.Show("Wrong attempt");
        }
    }




}
