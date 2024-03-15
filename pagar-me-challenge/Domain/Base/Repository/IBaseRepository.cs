using System.Threading.Tasks;

namespace pagar_me_challenge.Domains.Base.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
        Task<List<TEntity>> FindAllNoTracking();
    }
}
