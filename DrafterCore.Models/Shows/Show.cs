using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Shows
{
    public class Show : DateAware
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Season { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int MaxSelection { get; set; }
        [Required]
        public DateTime DraftEndDate { get; set; }
        [Required]
        public DateTime DraftStartDate { get; set; }
    }
}
