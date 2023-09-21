using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class PresentationRepository : GenericRepositoryA<Presentation>, IPresentationRepository{
    public PresentationRepository(PharmacyContex context) : base(context){}

   

}