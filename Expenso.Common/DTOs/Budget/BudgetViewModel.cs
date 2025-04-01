namespace Expenso.Common.DTOs.Budget
{
    public class BudgetViewModel
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Budget owner
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Budget name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Budget amount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Budget period (Monthly/Yearly/Custom)
        /// </summary>
        public string Period { get; set; } = string.Empty;

        /// <summary>
        /// Budget start date
        /// </summary>
        public string StartDate { get; set; } = string.Empty;

        /// <summary>
        /// Budget end date
        /// </summary>
        public string EndDate { get; set; } = string.Empty;
    }
}
