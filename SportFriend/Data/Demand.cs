using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportFriend.Data
{
   public class Demand
    {
        public int DemandId { get; set; }
        [Required]

        public string DemandContent { get; set; }


        public string DemandLocation { get; set; }

        public DateTime DemandTime { get; set; }



    }
}
