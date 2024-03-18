using Microsoft.AspNetCore.Mvc;
using pagar_me_challenge.Application.TransactionEntity.Dto;
using pagar_me_challenge.Application.TransactionEntity.Services;

namespace pagar_me_challenge.Application.TransactionEntity.Api
{
    public static class TransactionApi
    {
        public static void TransactionApiContext(this WebApplication app)
        {

            app.MapPost("/api/v1/Transaction", async (TransactionRequestDto dto, ITransactionApplicationService transactionApplicationService) =>
            {
                return await transactionApplicationService.Add(dto);
            });

            app.MapGet("/api/v1/Transaction", async (ITransactionApplicationService transactionApplicationService) =>
            {
                return await transactionApplicationService.Stats();
            });
        }
    }
}
