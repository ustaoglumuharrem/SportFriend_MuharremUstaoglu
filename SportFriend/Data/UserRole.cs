using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportFriend.Data
{
    public class UserRole
    {
        
        public int Id { get; set; }
        [Required]
        public string RoleContent { get; set; }
        [Required]
        public int RoleIdentification { get; set; }
        

    } 
}
