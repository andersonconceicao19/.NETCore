using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity: Entity
    {
        void Add(TEntity Obj);
        TEntity GetEntityById(Guid Id);
        IEnumerable<TEntity> GetAll();

        void Update(TEntity obg);
        void Remove(TEntity obj);

        void Dispose();
    }
}
