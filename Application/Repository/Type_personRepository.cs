using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class TypePersonRepository : GenericRepositoryA<Type_person>, IType_personRepository{
    public TypePersonRepository(PharmacyContex context) : base(context){}

   

}