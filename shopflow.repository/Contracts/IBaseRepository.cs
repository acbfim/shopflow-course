
namespace shopflow.repository.Contracts
{
    public interface IBaseRepository<T> where T: class
    {
        void AddAsync<T>(T entity) where T: class;

        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        
        void AddRangeAsync<T>(IEnumerable<T> entity) where T: class;
        void UpdateRange<T>(IEnumerable<T> entity) where T: class;
        void DeleteRange<T>(IEnumerable<T> entity) where T: class;

        Task<bool> SaveChangesAsync();
    }
}