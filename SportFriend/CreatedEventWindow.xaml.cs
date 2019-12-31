using Microsoft.EntityFrameworkCore;
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
        List<Events> list2;
        public CreatedEventWindow(FriendUser friendUser)
        {
            list2 = sportFriendDb.Events.OrderBy(f => f.EventDate).ToList<Events>();
            list2 = sportFriendDb.Events.Include(e => e.FriendUser).ToList();
            loginUser = friendUser;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dgAddEvent1.ItemsSource = list2;

            dgAddEvent2.ItemsSource = list2;
        }

       
        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You registered for event! You can see below!");
            Events events = dgAddEvent1.SelectedItem as Events;
            events.FriendUser = loginUser;
            sportFriendDb.Events.Update(events);
            sportFriendDb.SaveChanges();
            
            dgAddEvent2.Items.Refresh();
            



        }

        private void LoadEvents()
        {
            var events = sportFriendDb.Events.Include(e => e.FriendUser).ToList();
            dgAddEvent1.ItemsSource = events;
           



        
        }




        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Events events = dgAddEvent1.SelectedItem as Events;

            if (events != null && loginUser.Id == 1) 
            {
                sportFriendDb.Remove(events);
                sportFriendDb.SaveChanges();
                sportFriendDb.Events.Update(events);
                dgAddEvent1.Items.Refresh();
                dgAddEvent2.Items.Refresh();
                LoadEvents();

                MessageBox.Show("Event is deleted!");
            
            }
            
            else
            {
                MessageBox.Show("You do not have authorization!");
            }
        }
    }
}
