using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class BuyRepository : GenericRepositoryA<Buy>, IBuyRepository{
    public BuyRepository(PharmacyContext context) : base(context){}


protected override async Task<IEnumerable<Buy>> GetAll(Expression<Func<Buy, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Provider)
                .Include(x => x.Employee)
                .Include(x => x.Medicines)
                .Include(x => x.Detail_Buys)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Provider)
            .Include(x => x.Employee)
            .Include(x => x.Medicines)
            .Include(x => x.Detail_Buys)
            .ToListAsync();
    }
   

}
