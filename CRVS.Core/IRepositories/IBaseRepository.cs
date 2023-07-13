using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    Task<IEnumerable<T>> GetAllAsync();

    T GetById(int id);
    Task<T> GetByIdAsync(int id);

    void Add(T model);
    void Update(int id, T model);

    void Delete(int id);

    void SaveChanges();


}
}
