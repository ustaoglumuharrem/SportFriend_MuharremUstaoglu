using SportFriend.Data;
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

namespace SportFriend
{
    /// <summary>
    /// Interaction logic for CreateDemandWindow.xaml
    /// </summary>
    public partial class CreateDemandWindow : Window
    {

        private SportFriendDb sportFriendDb= new SportFriendDb();
        private FriendUser loginUser;
        public CreateDemandWindow(FriendUser friendUser)
        {
            
            loginUser = friendUser;
            
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddDemandWindow addDemandWindow = new AddDemandWindow(loginUser);
            addDemandWindow.Show();
        }

        public void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            var list = sportFriendDb.Demands.OrderBy(d => d.Time).Select(p => new { p.Id, p.Creator, p.Content, p.Location, p.Time }).ToList();
            dgAddDemand.ItemsSource = list;
        }


       

        
        
    }
}
