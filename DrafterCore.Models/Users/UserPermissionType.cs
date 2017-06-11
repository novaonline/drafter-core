using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Users
{
    public class UserPermissionType : DateAware
    {
        [StringLength(50), Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool CanEdit { get; set; }
        [Required]
        public bool CanDelete { get; set; }
        [Required]
        public bool CanRead { get; set; }
        [Required]
        public bool CanCreate { get; set; }
    }
}
