using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    ///<summary>
    /// Accounts (bank, cash, crypto, etc.)
    ///</summary>
    [Comment("Accounts (bank, cash, crypto, etc.)")]
    public class Account
    {
        /// <summary>
        /// Unique identifier of account
        /// </summary>
        [Key]
        [Comment("Account identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Owner of account
        /// </summary>
        [Required]
        [Comment("Account owner")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Name of account (Bank, Cash, etc.)
        /// </summary>
        [Required]
        [Comment("Account name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Type of account (bank, Paypal, crypto, etc.)
        /// </summary>
        [Required]
        [Comment("Account type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Balance of account
        /// </summary>
        [Precision(18, 2)]
        [Comment("Account balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// Currency of account
        /// </summary>
        [Required]
        [Comment("Account currency")]
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// Creation date of account
        /// </summary>
        [Required]
        [Comment("Account creation date")]
        public DateTime CreatedAt { get; set; }
    }
}
