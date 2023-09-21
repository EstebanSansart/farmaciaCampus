using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class Medicine_infoRepository : GenericRepositoryA<Medicine_info>, IMedicine_infoRepository{
    public Medicine_infoRepository(PharmacyContex context) : base(context){}

   

}