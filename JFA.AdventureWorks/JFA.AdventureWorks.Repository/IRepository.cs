using System.Collections.Generic;

namespace JFA.AdventureWorks.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetByID<TKey>(TKey id);
        object Add(T entity);
        void Save(T entity);
        void Delete<TKey>(TKey id);
        void Commit();
        List<T> Search(string what, int pageNo, int rows, out int totalRows, out int totalPages);
    }
}
