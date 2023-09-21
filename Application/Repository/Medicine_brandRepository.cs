using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Medicine_brandRepository : GenericRepositoryA<Medicine_brand>, IMedicine_brandRepository{
    public Medicine_brandRepository(PharmacyContex context) : base(context){}

   

}