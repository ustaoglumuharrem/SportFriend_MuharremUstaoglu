using Microsoft.EntityFrameworkCore;
using SportFriend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SportFriend.Service
{
    public class SportUserService
    {

        private SportFriendDb db;

        public SportUserService ()
        {
            db =new SportFriendDb();
        }

        

    public FriendUser Login(string UserName, string Password)
        {
            string hashedPasword = hashPassword(Password);
            var loginUser = db.FriendUser.Where(u => u.UserName == UserName && u.Password == hashedPasword).FirstOrDefault();

            return loginUser;
        }


        public bool CheckPassword(FriendUser user, string password)
        {
            return user.Password == hashPassword(password);
        }
        public string hashPassword(string plainPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var plainBytes = Encoding.UTF8.GetBytes(plainPassword);
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(plainBytes);

                // Convert byte array to a string 
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();

            }
        }










    }
}
