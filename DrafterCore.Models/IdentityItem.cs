using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models
{
    public class IdentityItem
    {
        [Required]
        public int Id { get; set; }
    }
}
