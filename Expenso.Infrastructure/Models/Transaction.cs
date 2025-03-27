using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expenso.Infrastructure.Models
{
    /// <summary>
    /// Tracks income and expenses
    /// </summary>
    [Comment("Tracks income and expenses")]
    public class Transaction
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        [Key]
        [Comment("Transaction identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Transaction owner
        /// </summary>
        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Linked account
        /// </summary>
        [Required]
        [Comment("Account identifier")]
        public int AccountId { get; set; }

        /// <summary>
        /// Amount of transaction
        /// </summary>
        [Required]
        [Comment("Transaction amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Type of transaction (Income, Expense)
        /// </summary>
        [Required]
        [Comment("Transaction type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Expense/income category
        /// </summary>
        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        /// <summary>
        /// Date of transaction
        /// </summary>
        [Required]
        [Comment("Transaction date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Description of transaction
        /// </summary>
        [Required]
        [Comment("Transaction description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Is it recurring (e.g. monthly bills)
        /// </summary>
        [Comment("Is transaction recurring")]
        public bool IsRecurring { get; set; }

        [ForeignKey(nameof(AccountId))]
        public Account Account { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
