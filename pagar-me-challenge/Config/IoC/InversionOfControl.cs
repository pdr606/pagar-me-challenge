using pagar_me_challenge.Application.TransactionEntity.Services;
using pagar_me_challenge.Domain.Entities.Payables.Services;
using pagar_me_challenge.Domain.Entities.PayablesEntity.Repository;
using pagar_me_challenge.Domain.Entities.PayablesEntity.Services;
using pagar_me_challenge.Domains.Base.Repository;
using pagar_me_challenge.Domains.Entities.TransactionEntity;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Repository;
using pagar_me_challenge.Domains.Entities.TransactionEntity.Services;

namespace pagar_me_challenge.Config.IoC
{
    public static class InversionOfControl
    {
        public static void InversionOfControlInject(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            builder.Services.AddScoped<ITransactionService, TransactionService>();
            builder.Services.AddScoped<ITransactionApplicationService, TransactionApplicationService>();
            builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

            builder.Services.AddScoped<IPayableService, PayableService>();
            builder.Services.AddScoped<IPayableRepository, PayableRepository>();
            
        }
    }
}
