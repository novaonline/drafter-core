using DrafterCore.Models.Shows;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DrafterCore.Models.Characters
{
    public class CharacterTransaction : DateAware
    {
        [Required]
        public int CharacterId { get; set; }
        [Required]
        public int ShowRoundId { get; set; }
        [Required]
        public CharacterTransactionType TransactionTypeId { get; set; }

        public Character Character { get; set; }
        public ShowRound ShowRound { get; set; }
    }
}
