using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sf.Budget.Core.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Save(T entity);
    }
}
