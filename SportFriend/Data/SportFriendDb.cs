using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportFriend.Data
{
   public class SportFriendDb:DbContext
    {
        string connectionString = @"Server=.;Database=newSportFriend; Trusted_Connection=True;";
        public DbSet<FriendUser> FriendUser { get; set; }
        public DbSet<Demand> Demand { get; set; }

    }
}
