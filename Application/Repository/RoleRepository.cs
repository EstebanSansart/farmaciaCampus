using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories;
public sealed class Rolrepository : GenericRepositoryA<Rol>, IRolRepository{
    public Rolrepository(PharmacyContex context) : base(context){}

    public async Task<Rol> GetRolByRoleName(Rols role)=> await FindFisrtAsync(x => x.Description == role.ToString());

    public async Task<Rol> GetRolByRoleName(string role) => await FindFisrtAsync(x => x.Description == role);
}