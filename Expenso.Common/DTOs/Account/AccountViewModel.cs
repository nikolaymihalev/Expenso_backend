namespace Expenso.Common.DTOs.Account
{
    public class AccountViewModel
    {
        /// <summary>
        /// Unique identifier of account
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Owner of account
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Name of account (Bank, Cash, etc.)
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Type of account (bank, Paypal, crypto, etc.)
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Balance of account
        /// </summary>
        public decimal Balance { get; set; }

        /// <summary>
        /// Currency of account
        /// </summary>
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// Creation date of account
        /// </summary>
        public string CreatedAt { get; set; } = string.Empty;
    }
}
