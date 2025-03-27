using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Tracking progress towards a specific financial goal
    /// </summary>
    [Comment("Tracking progress towards a specific financial goal")]
    public class SavingGoal
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Saving goal identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Saving goal owner
        /// </summary>
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Saving goal name
        /// </summary>
        [Required]
        [Comment("Saving goal name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Saving goal target amount
        /// </summary>
        [Required]
        [Precision(18, 2)]
        [Comment("Saving goal target amount")]
        public decimal TargetAmount { get; set; }

        /// <summary>
        /// Saving goal current amount
        /// </summary>
        [Required]
        [Precision(18, 2)]
        [Comment("Saving goal current amount")]
        public decimal CurrentAmount { get; set; }

        /// <summary>
        /// Saving goal deadline
        /// </summary>
        [Comment("Saving goal deadline")]
        public DateTime Deadline { get; set; }
    }
}
