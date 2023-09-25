using Domain.Entities.Generics;
using Persistence;

namespace Application.Repository.Generics;
public abstract class GenericRepositoryB<T> : GenericRepository<T> where T : BaseEntityB{
    public GenericRepositoryB(PharmacyContext context) : base(context){}
    public virtual async Task<T> GetByIdAsync(string id)=> await _Entity.FindAsync(id);
}