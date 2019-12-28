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
    /// Interaction logic for AddDemandWindow.xaml
    /// </summary>
    public partial class AddDemandWindow : Window
    {
        public AddDemandWindow(FriendUser friendUser)
        {

            InitializeComponent();
        }

        public void btnAddDemand_Click(object sender, RoutedEventArgs e)
        {

            Demands demand = new Demands();
            
            demand.Creator = txtCreator.Text;
            demand.Content = txtContent.Text;
            demand.Location = txtLocation.Text;
            demand.Time = datePicker.SelectedDate.Value;

            SportFriendDb database = new SportFriendDb();
            database.Demands.Add(demand);

            database.SaveChanges();
            MessageBox.Show("Demand Created");

            
            txtCreator.Text = "";
            txtContent.Text = "";
            txtLocation.Text = "";
            datePicker.SelectedDate = DateTime.Now;

            CreateDemandWindow createDemandWindow = new CreateDemandWindow(null);
            createDemandWindow.dgAddDemand.Items.Refresh();
            this.Close();

        }






    }
}
