using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportFriend.Data
{
   public class Demands
    {
        public int Id { get; set; }
        [Required]

        public string Content { get; set; }


        public string Location { get; set; }

        public DateTime Time { get; set; }



    }
}
