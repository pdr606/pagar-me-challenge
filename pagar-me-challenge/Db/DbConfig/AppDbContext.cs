using Microsoft.EntityFrameworkCore;
using pagar_me_challenge.Db.EntitiesConfig;
using pagar_me_challenge.Domain.Entities.PayablesEntity;
using pagar_me_challenge.Domains.Entities.TransactionEntity;

namespace pagar_me_challenge.Db.Config
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PayableConfig());
            modelBuilder.ApplyConfiguration(new TransactionConfig());
        }

        DbSet<Transaction> Transactions { get; set; }
        DbSet<Payable> Payables { get; set; }
    }
}
