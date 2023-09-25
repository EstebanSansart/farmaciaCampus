using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Generics.GenericId;

namespace Domain.Interfaces;
public interface IRoleRepository: IGenericRepositoryA<Role>{
    Task<Role> GetRoleByRoleName(UserRoles role);
    Task<Role> GetRoleByRoleName(string role);
}