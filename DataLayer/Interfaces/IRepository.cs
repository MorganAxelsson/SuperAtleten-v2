using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{    
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(Guid id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
    }
}
