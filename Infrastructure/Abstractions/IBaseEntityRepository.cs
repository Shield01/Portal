using System;
using System.Collections.Generic;
using System.Text;
using Core.Models;

namespace Infrastructure.Abstractions
{
    public interface IBaseEntityRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        T Create(T newObject);

        T Update(int id, T newObject);

        void Delete(int id);

        T EnableOrDisable(int id, bool isActive);
    }
}
