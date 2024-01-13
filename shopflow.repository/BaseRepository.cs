using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopflow.repository.Contexts;
using shopflow.repository.Contracts;

namespace shopflow.repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DefaultContext _context;

        public BaseRepository(DefaultContext context)
        {
            _context = context;
        }


        public async void AddAsync<T>(T entity) where T : class
        {
            await _context.AddAsync(entity);
        }

        public async void AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await _context.AddRangeAsync(entities);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.RemoveRange(entities);
        }

        

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void UpdateRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.UpdateRange(entities);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }
    }
}