using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Api
{
    internal interface ICRUD<T>
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public List<T> GetAll();
    }
}
