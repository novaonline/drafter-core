using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DrafterCore.Models.Shows;
using DrafterCore.Models.Users;

namespace DrafterCore.Models.Characters
{
    public class Character : DateAware
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int ShowId { get; set; }

        public User User { get; set; }
        public Show Show { get; set; }
    }
}
