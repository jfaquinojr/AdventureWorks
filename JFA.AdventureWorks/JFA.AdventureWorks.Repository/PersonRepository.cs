using JFA.AdventureWorks.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace JFA.AdventureWorks.Repository
{
    public class PersonRepository : IRepository<Person>
    {
        private AdventureWorksDb db = new AdventureWorksDb();

        public object Add(Person entity)
        {
            db.People.Add(entity);
            return entity.BusinessEntityID;
        }

        public void Commit()
        {
            db.SaveChanges();
        }

        public void Delete<TKey>(TKey id)
        {
            db.People.Remove(GetByID(id));
        }

        public List<Person> GetAll()
        {
            return db.People.ToList();
        }

        public List<Person> Search(string what, int pageNo, int rows, out int totalRows, out int totalPages)
        {
            var result = db.People
                .Where(m => m.FirstName.Contains(what) || m.LastName.Contains(what));
                //.AsEnumerable()
                //.Where(m => m.BusinessEntityID.ToString().Contains(what));

            var paginator = new Paginator<Person>(result.ToList());
            paginator.RowCount = rows;
            paginator.PageNumber = pageNo;
            totalRows = paginator.TotalRows;
            totalPages = paginator.TotalPages;

            return paginator.Rows;
        }

        public Person GetByID<TKey>(TKey id)
        {
            return db.People.Find(id);
        }

        public void Save(Person entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }

    }
}
