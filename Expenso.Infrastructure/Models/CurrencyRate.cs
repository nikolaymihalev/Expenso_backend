using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Currency rate converter
    /// </summary>
    [Comment("Currency rate converter")]
    public class CurrencyRate
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Unique identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Base currency
        /// </summary>
        [Required]
        [Comment("Base currency")]
        public string BaseCurrency { get; set; } = string.Empty;

        /// <summary>
        /// Converted currency
        /// </summary>
        [Required]
        [Comment("Converted currency")]
        public string TargetCurrency { get; set; } = string.Empty;

        /// <summary>
        /// Exchange rate
        /// </summary>
        [Required]
        [Comment("Exchange rate")]
        public decimal Rate { get; set; }

        /// <summary>
        /// Last update date
        /// </summary>
        [Required]
        [Comment("Last update date")]
        public DateTime UpdatedAt { get; set; }
    }
}
