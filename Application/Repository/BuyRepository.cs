using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class BuyRepository : GenericRepositoryA<Buy>, IBuyRepository{
    public BuyRepository(PharmacyContex context) : base(context){}

   

}
