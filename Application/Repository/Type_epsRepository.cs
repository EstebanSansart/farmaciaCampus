using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Type_epsRepository : GenericRepositoryA<Type_eps>, IType_epsRepository{
    public Type_epsRepository(PharmacyContex context) : base(context){}

   

}