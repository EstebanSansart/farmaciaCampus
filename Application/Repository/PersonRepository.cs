using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class PersonRepository : GenericRepositoryA<Person>, IPersonRepository{
    public PersonRepository(PharmacyContext context) : base(context){}

   

}