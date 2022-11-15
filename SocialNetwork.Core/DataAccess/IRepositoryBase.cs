using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SocialNetwork.Core.Entities;

namespace SocialNetwork.Core.DataAccess
{
    public interface IRepositoryBase<TEntity> where TEntity : class, IEntity
    {
          void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
        
    }
}