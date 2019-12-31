using SportFriend.Data;
using SportFriend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportFriend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private SportFriendDb Database = new SportFriendDb();
        //private FriendUser loginUser;

        public MainWindow()
        {

            InitializeComponent();
        }

        /*private void InitializeComponent()
        {
            throw new NotImplementedException();
        }*/

        public void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            SportUserService sportUserService = new SportUserService();


            var loginUser = sportUserService.Login(txtUserName.Text, txtUserPassword.Password);
            if (loginUser == null)
            {
                MessageBox.Show("UserName or password is wrong");
            }
            else
            {
                /// Doğru giriş yapıldı.
                User user = new User(loginUser);
                user.Show();
                this.Close();
            }






        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUpWindow = new SignUpWindow(null);
            signUpWindow.Show();

        }
    }
}
