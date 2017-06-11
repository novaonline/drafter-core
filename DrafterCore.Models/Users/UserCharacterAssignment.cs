using DrafterCore.Models.Characters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Users
{
    public class UserCharacterAssignment : DateAware
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public int CharacterId { get; set; }

        public User User { get; set; }
        public Character Character { get; set; }
    }
}
