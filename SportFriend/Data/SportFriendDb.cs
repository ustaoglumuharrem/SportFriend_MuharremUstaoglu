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

        public DbSet<RoleIdentification> RoleIdentifications { get; set; }

        public SportFriendDb() : base()
        {

        }
        public IEnumerable<object> FriendUsers { get; internal set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleIdentification>().HasData(

                new RoleIdentification
                {
                    Id = 1,
                    CreateDemand = 1,
                    CreateEvent = 1,
                    LookDemand = 1,
                    LookEvent = 1

                }

            
                );

            modelBuilder.Entity<RoleIdentification>().HasData(


                new RoleIdentification
                {
                    Id = 2,
                    CreateDemand = 1,
                    CreateEvent = 0,
                    LookDemand = 1,
                    LookEvent = 1
                }

                );



            modelBuilder.Entity<UserRole>().HasData(

                new UserRole
                {
                    Id = 1,
                    RoleContent = "Admin",
                    RoleIdentification = 1

                }
               

                );
            modelBuilder.Entity<UserRole>().HasData(

        
                new UserRole
                {
                    Id = 2,
                    RoleContent = "User",
                    RoleIdentification = 2

                }

                );
            modelBuilder.Entity<FriendUser>().HasData(

                new FriendUser
                {
                    Id = 1,
                    Name = "Muharrem",
                    Surname = "Ustaoglu",
                    UserName = "Muharrem",
                    BirthDate = new DateTime(1995, 05, 17),
                    CreatedDate = new DateTime(2019, 05, 17),
                    Password = new Service.SportUserService().hashPassword("19951995"),
                    RoleId = 1

                }
               
                );

            modelBuilder.Entity<FriendUser>().HasData(

             
               new FriendUser
               {
                   Id = 2,
                   Name = "Melike",
                   Surname = "Yılmaz",
                   UserName = "Melike",
                   BirthDate = new DateTime(1997, 07, 03),
                   CreatedDate = new DateTime(2019, 07, 03),
                   Password = new Service.SportUserService().hashPassword("19971997"),
                   RoleId = 2

               }
             

               );


            modelBuilder.Entity<FriendUser>().HasData(

             
               new FriendUser
               {
                   Id = 3,
                   Name = "Kemal",
                   Surname = "Karahan",
                   UserName = "Kemal",
                   BirthDate = new DateTime(1997, 03, 04),
                   CreatedDate = new DateTime(2019, 03, 04),
                   Password = new Service.SportUserService().hashPassword("19071907"),
                   RoleId = 2

               }
               );

            modelBuilder.Entity<FriendUser>().HasData(

        
               new FriendUser
               {
                   Id = 4,
                   Name = "Yusuf Mert",
                   Surname = "Bal",
                   UserName = "YMB",
                   BirthDate = new DateTime(1997, 03, 04),
                   CreatedDate = new DateTime(2019, 03, 04),
                   Password = new Service.SportUserService().hashPassword("ymbymb"),
                   RoleId = 2

               }
             

               );

            modelBuilder.Entity<FriendUser>().HasData(

              
                new FriendUser
                {
                    Id = 5,
                    Name = "Ferhat",
                    Surname = "Ören",
                    UserName = "Ferhat",
                    BirthDate = new DateTime(1990, 03, 04),
                    CreatedDate = new DateTime(2019, 03, 04),
                    Password = new Service.SportUserService().hashPassword("bimbim"),
                    RoleId = 2

                }

               );






          /*  modelBuilder.Entity<Demands>().HasData(

                new Demands
                {
                   Id=1,
                   Creator="Muharrem",
                   Participator=null,
                   Content="Basketball",
                   Location="Hisarüstü",
                   Time=new DateTime(2020,01,01)


                }
               

            );
            modelBuilder.Entity<Demands>().HasData(

         new Demands
         {
             Id = 2,
             Creator = "Melike",
             Participator = null,
             Content = "Tennis",
             Location = "Caddebostan",
             Time = new DateTime(2020, 01, 02)


         }
       
     );

            modelBuilder.Entity<Demands>().HasData(

       
         new Demands
         {
             Id = 3,
             Creator = "Kemal",
             Participator = null,
             Content = "Fitness",
             Location = "Beşiktaş",
             Time = new DateTime(2020, 01, 03)

         }

     );

    */

            modelBuilder.Entity<Events>().HasData(

               new Events
               {
                   Id = 1,
                   EventCreator="Muharrem Ustaoğlu",
                     EventName="İstanbul Marathon",
                      EventLocation="İstanbul",
                       EventType="Running",
                        EventDate=new DateTime(2020-3-1)
                   
                   

               }
            




           );

            modelBuilder.Entity<Events>().HasData(

          
               new Events
               {
                   Id = 2,
                   EventCreator = "Muharrem Ustaoğlu",
                   EventName = "Antalya Swimming",
                   EventLocation = "Antalya",
                   EventType = "Swimming",
                   EventDate = new DateTime(2020 - 7 - 1)

               }





           );



        }


    }
}
