using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HotelApi.Data;
using HotelApi.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.IRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
        public async Task Delete(int id)
        {
            var item = await _db.FindAsync(id);
            _db.Remove(item);
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            _db.RemoveRange(items);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            IQueryable<T> query = _db;

            if ( includes != null )
            {
                foreach(var item in includes)
                {
                    query = query.Include(item);
                }
            }

            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            IQueryable<T> _query = _db;

            if( expression != null )
            {
                _query = _query.Where(expression);
            }

            if ( orderBy != null )
            {
                _query = orderBy(_query);
            }

            if ( includes != null )
            {
                foreach ( var item in includes )
                {
                    _query = _query.Include(item);
                }
            }

            return await _query.AsNoTracking().ToListAsync();

            
        }

        public async Task Insert(T item)
        {
            await _db.AddAsync(item);
        }

        public async Task InsertRange(IEnumerable<T> items)
        {
            await _db.AddRangeAsync(items);
        }

        public void Update(T item)
        {
            _db.Attach(item);
        }
    }
}
