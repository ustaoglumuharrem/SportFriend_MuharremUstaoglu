using SportFriend.Data;
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
    /// Interaction logic for EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window
    {
       
        public EventWindow(FriendUser friendUser)
        {
            InitializeComponent();
        }

        public void btnAddEvent_Click(object sender, RoutedEventArgs e)
        {
            Events events = new Events();
            events.EventCreator = txtCreator1.Text;
            events.EventName = txtContent1.Text;
            events.EventType = txtType1.Text;
            events.EventLocation = txtLocation1.Text;
            events.EventDate = datePicker1.SelectedDate.Value;


            SportFriendDb database = new SportFriendDb();
            database.Events.Add(events);

            database.SaveChanges();
            MessageBox.Show("Events Created");


            txtCreator1.Text = "";
            txtContent1.Text = "";
            txtType1.Text = "";
            txtLocation1.Text = "";
            datePicker1.SelectedDate = DateTime.Now;

            CreatedEventWindow createdEventWindow = new CreatedEventWindow(null);
            createdEventWindow.dgAddEvent1.Items.Refresh();
            this.Close();




        }
    }
}
