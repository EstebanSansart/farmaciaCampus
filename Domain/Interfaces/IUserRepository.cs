using Domain.Entities;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;
public interface IUserRepository: IGenericRepositoryA<User>{
    Task<User> GetUserByName(string name);
}