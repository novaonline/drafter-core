using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Shows
{
    public class ShowRound : DateAware
    {
        [Required]
        public int ShowId { get; set; }
        [Required]
        public int RoundNumber { get; set; }

        public Show Show { get; set; }
    }
}
