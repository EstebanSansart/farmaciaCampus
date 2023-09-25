using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class ProviderRepository : GenericRepositoryA<Provider>, IProviderRepository{
    public ProviderRepository(PharmacyContext context) : base(context){}

   

}