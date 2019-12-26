using Microsoft.EntityFrameworkCore;
using SportFriend.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportFriend.Data
{
   public class SportFriendDb:DbContext
    {
        string connectionString = @"Server=.;Database=SportFriend301; Trusted_Connection=True;";
        public DbSet<FriendUser> FriendUser { get; set; }
        public DbSet<Demands> Demands { get; set; }
        
        public DbSet<Events> Events { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public SportFriendDb() : base()
        {

        }
        public IEnumerable<object> FriendUsers { get; internal set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

    }
}
