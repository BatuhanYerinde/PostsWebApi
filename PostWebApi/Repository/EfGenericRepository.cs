using Microsoft.EntityFrameworkCore;
using PostWebApi.Data;

namespace PostsWebApi.Repository
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _dbSet;

        public EfGenericRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public List<T> GetAll()
        {
            var postList = _dbSet.ToList();
            return postList;
        }

        public T GetById(int id)
        {
            var post = _dbSet.Find(id);
            return post;
        }

        public T UpdateById(T entity, int id)
        {
            var post = _dbSet.Find(id);
            if (post != null)
            {
                _context.Entry(post).CurrentValues.SetValues(entity);
                _context.SaveChanges();
                return post;
            }
            return null;

        }
    }
}
