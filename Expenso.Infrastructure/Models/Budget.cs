using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Budget planning and management
    /// </summary>
    [Comment("Budget planning and management")]
    public class Budget
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Budget identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Budget owner
        /// </summary>
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Budget name
        /// </summary>
        [Required]
        [Comment("Budget name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Budget amount
        /// </summary>
        [Required]
        [Comment("Budget amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Budget period (Monthly/Yearly/Custom)
        /// </summary>
        [Required]
        [Comment("Budget period")]
        public string Period { get; set; } = string.Empty;

        /// <summary>
        /// Budget start date
        /// </summary>
        [Required]
        [Comment("Budget start date")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Budget end date
        /// </summary>
        [Required]
        [Comment("Budget end date")]
        public DateTime EndDate { get; set; }
    }
}
