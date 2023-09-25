using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Type_providerRepository : GenericRepositoryA<Type_provider>, IType_providerRepository{
    public Type_providerRepository(PharmacyContext context) : base(context){}

   

}