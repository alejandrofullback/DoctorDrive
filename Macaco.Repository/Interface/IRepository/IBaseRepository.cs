using System.Collections.Generic;
using Macaco.Infraestructure.Domain;

namespace Macaco.Repository.Interface.IRepository
{
    public interface IBaseRepository<T> where T : EntityBase, IAggregateRoot
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T FindById(int id);
        IEnumerable<T> Find(dynamic param);
        IEnumerable<T> Find(string query, dynamic param);
        IEnumerable<T> FindAll();
    }
}
