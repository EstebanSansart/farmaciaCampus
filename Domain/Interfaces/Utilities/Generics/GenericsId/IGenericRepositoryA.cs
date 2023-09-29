using Domain.Entities.Generics;

namespace Domain.Interfaces.Generics.GenericId;
public interface IGenericRepositoryA<T>: IGenericRepository<T> where T: BaseEntityA{
    Task<T> GetByIdAsync(int id);
}