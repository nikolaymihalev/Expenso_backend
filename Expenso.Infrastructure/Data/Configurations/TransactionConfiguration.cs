using Expenso.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Expenso.Infrastructure.Data.Configurations
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasOne(x => x.Account).WithMany(x => x.Transactions).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Category).WithMany(x => x.Transactions).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
