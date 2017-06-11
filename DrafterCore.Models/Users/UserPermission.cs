using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Users
{
    public class UserPermission : DateAware
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public int UserPermissionTypeId { get; set; }
    }
}
