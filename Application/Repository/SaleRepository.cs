using System.Linq.Expressions;
using Application.Repository.Generics.GenericsId;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
public sealed class SaleRepository : GenericRepositoryA<Sale>, ISaleRepository{
    public SaleRepository(PharmacyContext context) : base(context){}


      protected override async Task<IEnumerable<Sale>> GetAll(Expression<Func<Sale, bool>> expression = null)
    {
        if (expression is not null)
        {
            return await _Entities
                .Include(x => x.Employee)
                .Include(x => x.Person)
                .Include(x => x.Orders)
                .Where(expression).ToListAsync();
        }
        return await _Entities
            .Include(x => x.Employee)
            .Include(x => x.Person)
            .Include(x => x.Orders)
            .ToListAsync();
    }
   

}