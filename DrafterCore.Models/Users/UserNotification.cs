using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DrafterCore.Models.Users
{
    public class UserNotification : DateAware
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string NotificationMessage { get; set; }
        
        public DateTime? ReadDate { get; set; }
    }
}
