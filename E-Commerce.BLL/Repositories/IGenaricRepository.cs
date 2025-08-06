using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BLL.Repositories
{
    public interface IGenaricRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int Id);

        Task<int> Add(T item);

        Task<int> Delete(T item);
        Task<int> Update(T item);
    }
}
