using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DAL._Repositories._GenericRepository
{
    public interface IGenericRepo<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByID(int id);

        Task<T> AddElement(T item);

        Task<T> UpdateElement(T item);

        Task<T> Delete(T item);

        Task<T> DeleteById(int id);
    }
}
