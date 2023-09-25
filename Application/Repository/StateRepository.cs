using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class StateRepository : GenericRepositoryA<State>, IStateRepository{
    public StateRepository(PharmacyContext context) : base(context){}

   

}