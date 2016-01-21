using JFA.AdventureWorks.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

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
