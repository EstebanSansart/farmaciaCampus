using Domain.Entities.Generics;

namespace Domain.Interfaces.Generics.GenericsId;
public interface IGenericRepositoryB<T>: IGenericRepository<T> where T: BaseEntityB{
    Task<T> GetByIdAsync(string id);    
}