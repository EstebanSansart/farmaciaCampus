using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;
public interface IRolRepository: IGenericRepositoryA<Rol>{
    Task<Rol> GetRolByRoleName(Rols rol);
    Task<Rol> GetRolByRoleName(string rol);
}