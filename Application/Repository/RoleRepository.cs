using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class RoleRepository : GenericRepositoryA<Role>, IRoleRepository{
    public RoleRepository(PharmacyContext context) : base(context){}

    public async Task<Role> GetRolByRoleName(Roles role)=> await FindFisrtAsync(x => x.Description == role.ToString());

    public async Task<Role> GetRolByRoleName(string role) => await FindFisrtAsync(x => x.Description == role);
}