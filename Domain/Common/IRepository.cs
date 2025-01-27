using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IRepository<T> where T : class
    {
        Task<T> SaveAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<T> DeleteById(int id);
    }
}
