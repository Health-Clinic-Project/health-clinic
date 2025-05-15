using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    public interface ICRUD<T>
    {
        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(T entity);
        public Task<List<T>> GetAll();
       
    }
}
