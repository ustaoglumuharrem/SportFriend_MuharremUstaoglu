﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportFriend.Data
{
    public class FriendUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength =4)]
        
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string Surname { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string UserName { get; set; }
        [Required]
        [StringLength(256)]

        public DateTime BirthDate { get; set; }
        public string Password { get; set; }


        public DateTime CreatedDate { get; set; }

        public int RoleId { get; set; }



    }
}
