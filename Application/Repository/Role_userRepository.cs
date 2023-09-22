using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Role_userRepository : GenericRepositoryA<Role_user>, IRole_userRepository{
    public Role_userRepository(PharmacyContex context) : base(context){}

   

}