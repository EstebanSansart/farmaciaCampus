using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class PositionRepository : GenericRepositoryA<Position>, IPositionRepository{
    public PositionRepository(PharmacyContex context) : base(context){}

}