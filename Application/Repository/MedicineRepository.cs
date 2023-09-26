using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;
public sealed class MedicineRepository : GenericRepositoryA<Medicine>, IMedicineRepository{ 
     private readonly PharmacyContext _context;
    public MedicineRepository(PharmacyContext context) : base(context){
        _context = context;

    }
   


}