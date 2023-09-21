using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class EpsRepository : GenericRepositoryA<Eps>, IEpsRepository{
    public EpsRepository(PharmacyContex context) : base(context){}

}