using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class MedicineRepository : GenericRepositoryA<Medicine>, IMedicineRepository{
    public MedicineRepository(PharmacyContext context) : base(context){}

   

}