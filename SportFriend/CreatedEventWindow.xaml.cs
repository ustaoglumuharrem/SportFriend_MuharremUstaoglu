﻿using SportFriend.Data;
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
    /// Interaction logic for CreatedEventWindow.xaml
    /// </summary>
    public partial class CreatedEventWindow : Window
    {
        public CreatedEventWindow(FriendUser friendUser)
        {
            InitializeComponent();
        }
    }
}