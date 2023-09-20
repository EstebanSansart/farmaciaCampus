using Domain.Entities.Generics;
using Persistence;

namespace Application.Repository.Generics.GenericsId;
public abstract class GenericRepositoryA<T> : GenericRepository<T> where T : BaseEntityA{
    public GenericRepositoryA(PharmacyContex context) : base(context){}
    public virtual async Task<T> GetByIdAsync(int id)=> await _Entity.FindAsync(id);
}