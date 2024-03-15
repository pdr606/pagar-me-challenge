using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using pagar_me_challenge.Domain.Entities.PayablesEntity;

namespace pagar_me_challenge.Db.EntitiesConfig
{
    public class PayableConfig : IEntityTypeConfiguration<Payable>
    {
        public void Configure(EntityTypeBuilder<Payable> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status).IsRequired();

            builder.Property(x => x.Fee).IsRequired();

            builder.Property(x => x.PaymenteDate).IsRequired();

        }
    }
}
