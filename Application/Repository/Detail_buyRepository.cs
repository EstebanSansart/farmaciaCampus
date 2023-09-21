using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Detail_buyRepository : GenericRepositoryA<Detail_buy>, IDetail_buyRepository{
    public Detail_buyRepository(PharmacyContex context) : base(context){}

   

}