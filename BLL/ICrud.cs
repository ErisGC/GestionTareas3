using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ICrud
    {
        public interface ICrudRepository<T>
        {
            void Add(T entity);
            T Read(int id);
            List<T> ReadAll();
            void Update(T entity);
            void Delete(int id);
        }

    }
}
