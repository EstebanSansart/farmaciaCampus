using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class RolRepository : GenericRepositoryA<Rol>, IRolRepository{
    public RolRepository(PharmacyContex context) : base(context){}

    public async Task<Rol> GetRolByRoleName(Roles rol)=> await FindFisrtAsync(x => x.Description == rol.ToString());

    public async Task<Rol> GetRolByRoleName(string rol) => await FindFisrtAsync(x => x.Description == rol);
}