using ShopIt.Models;

namespace ShopIt.Interfaces
{
    public interface IGenericRespository<T> where T : BaseEntity
    {
        Task<T> Create(T entity);
        Task<T> Get(Guid id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Update(T entity);
        Task<T> Delete(Guid id);

    }
}
