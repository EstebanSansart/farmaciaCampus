using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class AddressRepository : GenericRepositoryA<Address>, IAddressRepository{
    public AddressRepository(PharmacyContext context) : base(context){}

   

}