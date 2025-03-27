using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Expense/income categories
    /// </summary>
    [Comment("Expense/income categories")]
    public class Category
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Unique identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Category name (e.g. "Food", "Transportation")
        /// </summary>
        [Required]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Category type (Income/Expense)
        /// </summary>
        [Required]
        [Comment("Category type")]
        public string Type { get; set; } = string.Empty;

        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
