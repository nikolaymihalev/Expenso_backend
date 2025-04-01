using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Investment tracking (stocks, cryptocurrencies)
    /// </summary>
    [Comment("Investment tracking (stocks, cryptocurrencies)")]
    public class Investment
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Investment identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Owner
        /// </summary>
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Stock, Crypto, Real Estate, etc.
        /// </summary>
        [Required]
        [Comment("Investment asset type")]
        public string AssetType { get; set; } = string.Empty;

        /// <summary>
        /// Asset name
        /// </summary>
        [Required]
        [Comment("Investment name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Invested amount
        /// </summary>
        [Required]
        [Precision(18, 2)]
        [Comment("Invested amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Current value
        /// </summary>
        [Required]
        [Precision(18, 2)]
        [Comment("Current value")]
        public decimal CurrentValue { get; set; }
    }
}
