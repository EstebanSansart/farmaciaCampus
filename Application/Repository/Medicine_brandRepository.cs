using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Medicine_brandRepository : GenericRepositoryA<Medicine_brand>, IMedicine_brandRepository{
    public Medicine_brandRepository(PharmacyContext context) : base(context){}


           protected override async Task<IEnumerable<Medicine_brand>> GetAll(Expression<Func<Medicine_brand, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Medicine_Infos)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Medicine_Infos)            
            .ToListAsync();
    }
   

}