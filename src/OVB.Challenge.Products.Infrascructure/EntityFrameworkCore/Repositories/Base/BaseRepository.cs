using OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Repositories.Base.Interfaces;

namespace OVB.Challenge.Products.Infrascructure.EntityFrameworkCore.Repositories.Base;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class
{
    protected readonly DataContext _dataContext;

    protected BaseRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public virtual Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        => _dataContext.Set<TEntity>().AddAsync(entity, cancellationToken).AsTask();
}
