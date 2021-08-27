using Core.Models;
using Infrastructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.ConcreteImplementation
{
    class BaseEntityRepository<T> : IBaseEntityRepository<T> where T : BaseEntity
    {
        private List<T> Database;

        public BaseEntityRepository()
        {
            Database = new List<T>();
        }
        public T Create(T newObject)
        {
            Database.Add(newObject);
            return newObject;
        }

        public void Delete(int id)
        {
            var entity = Database.FirstOrDefault(x => x.Id == id);
            Database.Remove(entity);
        }

        public T EnableOrDisable(int id, bool isActive)
        {
            var entity = Database.FirstOrDefault(x => x.Id == id);

            if (entity.IsActive)
            {
                entity.IsActive = false;
            }else if (!entity.IsActive)
            {
                entity.IsActive = true;
            }

            return entity;
        }

        public T Get(int id)
        {
            var entity = Database.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return Database;
        }

        public T Update(int id, T newObject)
        {
            var entity = Database.FirstOrDefault(x => x.Id == newObject.Id);
            entity.Id = newObject.Id;
            entity.IsActive = newObject.IsActive;
            entity.DateModified = DateTime.Now;

            return entity;
        }
    }
}
