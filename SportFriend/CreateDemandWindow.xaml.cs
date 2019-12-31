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
        List<Demands> list;
        public CreateDemandWindow(FriendUser friendUser)
        {
            list = sportFriendDb.Demands.OrderBy(f => f.Time).ToList<Demands>();
            
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

           // var list = sportFriendDb.Demands.OrderBy(d => d.Time).Select(p => new { p.Id, p.Creator, p.Content, p.Location, p.Time }).ToList();
            dgAddDemand.ItemsSource = list;
            dgMatch.ItemsSource = list;

        }

      

        private void btnJoin_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You matched! You can see below!");
            Demands demands = dgAddDemand.SelectedItem as Demands;

            demands.Participator = loginUser.Name;
            sportFriendDb.Demands.Update(demands);
            sportFriendDb.SaveChanges();

            dgMatch.Items.Refresh();








        }
    }
}
