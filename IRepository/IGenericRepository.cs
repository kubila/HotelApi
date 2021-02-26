using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace HotelApi.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null);
        
        Task Insert(T item);

        Task InsertRange(IEnumerable<T> items);

        Task Delete(int id);

        void DeleteRange(IEnumerable<T> items);

        void Update(T item);
    }
}
