using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class SaleRepository : GenericRepositoryA<Sale>, ISaleRepository{
    public SaleRepository(PharmacyContex context) : base(context){}

   

}