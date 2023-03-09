

using Factory_Automation_Solutions.Domain.Models;

namespace Factory_Automation_Solutions.Application.Common.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : EntityBase
    {
        TEntity Get(ulong id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity, ulong id);
        TEntity Delete(ulong id);
    }
}
