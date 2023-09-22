
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Detail_saleRepository : GenericRepositoryA<Detail_sale>, IDetail_saleRepository{
    public Detail_saleRepository(PharmacyContex context) : base(context){}

}