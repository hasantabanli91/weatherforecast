using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weatherforecast.DAL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T Insert(T entity);
        T Update(int id, T entity);
        void Delete(T entity);
        T Get(int idEntity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
