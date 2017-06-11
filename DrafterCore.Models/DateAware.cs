using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DrafterCore.Models
{
    public class DateAware : IdentityItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UTCAddDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UTCUpdateDate { get; set; }
    }
}
