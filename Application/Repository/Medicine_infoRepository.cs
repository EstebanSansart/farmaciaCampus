using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Entities.Generics;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class Medicine_infoRepository : GenericRepositoryA<Medicine_info>, IMedicine_infoRepository{
    public Medicine_infoRepository(PharmacyContext context) : base(context){}
     protected override async Task<IEnumerable<Medicine_info>> GetAll(Expression<Func<Medicine_info, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Category)        
                .Include(x => x.Presentation)        
                .Include(x => x.Medicine_brand)
                .Include(x => x.Inventories)
                .Where(expression).ToListAsync();
        }
        return await _Entities
                .Include(x => x.Category)        
                .Include(x => x.Presentation)        
                .Include(x => x.Medicine_brand)
                .Include(x => x.Inventories)
            .ToListAsync();
    }
   

}