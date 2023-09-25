using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Type_PersonRepository : GenericRepositoryA<Type_person>, IType_personRepository{
    public Type_PersonRepository(PharmacyContext context) : base(context){}

   

}