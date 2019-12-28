using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SportFriend.Data
{
    public class Events
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 4)]

        public string EventCreator { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]

        public string EventType { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]


        public string EventLocation { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]

        public DateTime EventDate { get; set; }








    }
}
