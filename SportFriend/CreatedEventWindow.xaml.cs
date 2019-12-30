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
    /// Interaction logic for CreatedEventWindow.xaml
    /// </summary>
    public partial class CreatedEventWindow : Window
    {
        private SportFriendDb sportFriendDb = new SportFriendDb();
        private FriendUser loginUser;
        public CreatedEventWindow(FriendUser friendUser)
        {
            loginUser = friendUser;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


            var list2 = sportFriendDb.Events.OrderBy(f => f.EventDate).Select(t => new { t.Id, t.EventCreator,t.EventName,t.EventType,t.EventLocation,t.EventDate }).ToList();
            dgAddEvent1.ItemsSource = list2;




        }

        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {

            



        }
    }
}
