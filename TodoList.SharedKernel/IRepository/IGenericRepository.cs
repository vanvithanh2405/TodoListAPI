using System.Linq.Expressions;
namespace Asenda.DHP.SharedKernel.IRepository
{
    public interface IGenericRepository<T> : IDisposable
    {
        IQueryable<T> All();
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> AllIncluding(string includeProperties);
        IQueryable<T> Filter(Expression<Func<T, bool>> predicate);
        IQueryable<T> Filter(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50);
        bool Contains(Expression<Func<T, bool>> predicate);
        T? Find(params object[] keys);
        T? Find(Expression<Func<T, bool>> predicate);
        T Create(T t);
        Task<T> CreateAsync(T TObject);
        void CreateRange(IEnumerable<T> values);
        Task CreateRangeAsync(IEnumerable<T> values);
        int Update(T t);
        int Delete(Expression<Func<T, bool>> predicate);
        int Delete(T t);
        int DeleteRange(IEnumerable<T> t);
        void Save();
        Task SaveAsync();
        IList<T> RawSqlToList(string stringFormat, params object[] parameters);
        int UpdateRange(IEnumerable<T> entities);
        List<T> FindAll(Expression<Func<T, bool>> predicate);
        int ExecuteSqlRaw(string stringFormat, params object[] parameters);
    }
}
