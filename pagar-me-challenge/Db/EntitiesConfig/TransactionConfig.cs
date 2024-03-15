using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Db.EntitiesConfig
{
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PaymentMethod).IsRequired();

            builder.OwnsOne(x => x.Card);

            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(x => x.Payable)
                    .WithOne(x => x.Transaction)
                    .HasForeignKey<Transaction>(x => x.PayableId)
                    .IsRequired();
        }
    }
}
