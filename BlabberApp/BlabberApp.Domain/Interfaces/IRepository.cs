using System.Collections.Generic;
using BlabberApp.Domain.Entities;

namespace BlabberApp.Domain {
    public interface IRepository<T> where T : Model {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}